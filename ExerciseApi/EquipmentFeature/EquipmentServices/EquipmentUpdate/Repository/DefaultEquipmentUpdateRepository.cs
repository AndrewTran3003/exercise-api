using AutoMapper;
using ExerciseApi.Data;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.EquipmentFeature.Models.Dto;
using ExerciseApi.Helpers;
using ExerciseApi.Models.Equipment;
using Microsoft.EntityFrameworkCore;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Repository
{
    public class DefaultEquipmentUpdateRepository : IEquipmentUpdateRepository
    {
        private readonly IDbContextFactory<ExerciseApiDbContext> _context;
        private readonly IMapper _mapper;
        public DefaultEquipmentUpdateRepository(IDbContextFactory<ExerciseApiDbContext> context)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EquipmentEntity, BaseEquipment>());
            _mapper = config.CreateMapper();
            _context = context;
        }

        public async Task<bool> EquipmentExitsAsync(EquipmentDto equipment)
        {
            await using ExerciseApiDbContext context = _context.CreateDbContext();
            return context.BaseEquipments.Any(e => e.Id == equipment.Id);
        }

        public async Task<bool> EquipmentsExistAsync(List<EquipmentDto> equipmentList)
        {
            foreach (EquipmentDto equipment in equipmentList)
            {
                if (! await EquipmentExitsAsync(equipment))
                {
                    return false;
                }
            }
            return true;
        }

        public async Task<OperationResult<object>> UpdateAsync(EquipmentDto equipmentIncoming)
        {
            try
            {
                await using ExerciseApiDbContext context = _context.CreateDbContext();
                var equipmentCurrent = await FindExistingEquipmentByIdAsync(context, equipmentIncoming.Id);
                UpdateEquipmentInfo(equipmentCurrent, equipmentIncoming);
                await context.SaveChangesAsync();
                return new OperationResult<object>(OperationStatus.Success, "Item updated", null);
            }
            catch (Exception e)
            {
                return new OperationResult<object>(OperationStatus.Error, e.Message, null);
            }
        }

        public async Task<OperationResult<object>> UpdateMultipleAsync(List<EquipmentDto> equipments)
        {
            try
            {
                await using ExerciseApiDbContext context = _context.CreateDbContext();
                foreach (EquipmentDto equipmentIncoming in equipments)
                {
                    var equipmentCurrent = await FindExistingEquipmentByIdAsync(context, equipmentIncoming.Id);
                    UpdateEquipmentInfo(equipmentCurrent, equipmentIncoming);
                }
                await context.SaveChangesAsync();
                return new OperationResult<object>(OperationStatus.Success, "Item updated", null);
            }
            catch (Exception e)
            {
                return new OperationResult<object>(OperationStatus.Error, e.Message, null);
            }
        }

        private async Task<BaseEquipment> FindExistingEquipmentByIdAsync (ExerciseApiDbContext context, Guid? equipmentId)
        {
            return context.BaseEquipments.First(e => e.Id == equipmentId);
        }

        private void UpdateEquipmentInfo(BaseEquipment equipmentCurrent, EquipmentDto equipmentIncoming)
        {
            equipmentCurrent.Name = equipmentIncoming.Name;
            equipmentCurrent.Description = equipmentIncoming.Description;
            equipmentCurrent.Price = float.Parse(equipmentIncoming.Price.ToString());
            equipmentCurrent.LastUpdated = DateTime.UtcNow;
            equipmentCurrent.LastUpdatedBy = "Root";
        }
    }
}