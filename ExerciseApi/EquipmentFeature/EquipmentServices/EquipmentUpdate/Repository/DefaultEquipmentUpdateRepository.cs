using AutoMapper;
using ExerciseApi.Data;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;
using ExerciseApi.Models.Equipment;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Repository
{
    public class DefaultEquipmentUpdateRepository : IEquipmentUpdateRepository
    {
        private readonly ExerciseApiDbContext _context;
        private readonly IMapper _mapper;
        public DefaultEquipmentUpdateRepository(ExerciseApiDbContext context)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EquipmentEntity, BaseEquipment>());
            _mapper = config.CreateMapper();
            _context = context;
        }

        public bool EquipmentExits(EquipmentEntity equipment)
        {
            return _context.BaseEquipments.Any(e => e.Id == equipment.Id);
        }

        public async Task<OperationResult<object>> UpdateAsync(EquipmentEntity equipmentIncoming)
        {
            try
            {
                var equipmentCurrent = _context.BaseEquipments.First(e => e.Id == equipmentIncoming.Id);
                UpdateEquipmentInfo(equipmentCurrent, equipmentIncoming);
                await _context.SaveChangesAsync();
                return new OperationResult<object>(OperationStatus.Success, "Item updated", null);
            }
            catch (Exception e)
            {
                return new OperationResult<object>(OperationStatus.Error, e.Message, null);
            }
        }

        private void UpdateEquipmentInfo(BaseEquipment equipmentCurrent, BaseEquipment equipmentIncoming)
        {
            equipmentCurrent.Name = equipmentIncoming.Name;
            equipmentCurrent.Description = equipmentIncoming.Description;
            equipmentCurrent.Price = equipmentIncoming.Price;
            equipmentCurrent.LastUpdated = DateTime.UtcNow;
            equipmentCurrent.LastUpdatedBy = "Root";
        }
    }
}