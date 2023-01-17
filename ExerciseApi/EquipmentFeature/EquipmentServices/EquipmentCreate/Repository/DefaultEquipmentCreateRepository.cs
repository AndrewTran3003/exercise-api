using AutoMapper;
using ExerciseApi.Data;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.EquipmentFeature.Models.Dto;
using ExerciseApi.Helpers;
using ExerciseApi.Models.Equipment;
using Microsoft.EntityFrameworkCore;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Repository
{
    public class DefaultEquipmentCreateRepository : IEquipmentCreateRepository
    {
        private readonly IDbContextFactory<ExerciseApiDbContext> _context;
        private readonly IMapper _mapper;

        public DefaultEquipmentCreateRepository(IDbContextFactory<ExerciseApiDbContext> context)
        {
            _mapper = CreateMapper();
            _context = context;
        }
        public async Task<OperationResult<EquipmentEntity>> CreateAsync(EquipmentDto equipment)
        {
            await using ExerciseApiDbContext context = _context.CreateDbContext();

            try
            {
                var baseEquipment = ParseEquipment(equipment);
                await context.BaseEquipments.AddAsync(baseEquipment);
                await context.SaveChangesAsync();
                var createdEquipment = GetCreatedEquipment(baseEquipment);
                return new OperationResult<EquipmentEntity>(OperationStatus.Success, String.Empty, createdEquipment);
            }
            catch (Exception e)
            {
                return new OperationResult<EquipmentEntity>(OperationStatus.ServerError, e.Message, null);
            }

        }

        public async Task<OperationResult<List<EquipmentEntity>>> CreateListAsync(List<EquipmentEntity> equipmentList)
        {
            await using ExerciseApiDbContext context = _context.CreateDbContext();
            try
            {
                var baseEquipmentList = ParseBaseEquipmenttList(equipmentList);
                await context.BaseEquipments.AddRangeAsync(baseEquipmentList);
                await context.SaveChangesAsync();
                var createdEquipments = GetCreatedEquipments(baseEquipmentList);
                return new OperationResult<List<EquipmentEntity>>(OperationStatus.Success, String.Empty, createdEquipments);
            }
            catch (Exception e)
            {
                return new OperationResult<List<EquipmentEntity>>(OperationStatus.ServerError, e.Message, null);
            }
        }

        private EquipmentEntity GetCreatedEquipment(BaseEquipment equipment)
        {
            return _mapper.Map<EquipmentEntity>(equipment);
        }

        private List<EquipmentEntity> GetCreatedEquipments(List<BaseEquipment> equipmentList)
        {
            return equipmentList
                    .Select(e => _mapper.Map<EquipmentEntity>(e))
                    .ToList();
        }

        private IMapper CreateMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EquipmentEntity, BaseEquipment>();
                cfg.CreateMap<BaseEquipment, EquipmentEntity>();
                cfg.CreateMap<EquipmentDto, BaseEquipment>();
            })
            .CreateMapper();
        }

        private List<BaseEquipment> ParseBaseEquipmenttList(List<EquipmentEntity> equipmentList)
        {
            return equipmentList
                    .Select(e => ParseBasedEquipment(e))
                    .ToList();
        }

        private BaseEquipment ParseBasedEquipment(EquipmentEntity equipment)
        {
            var result = _mapper.Map<BaseEquipment>(equipment);
            result.Id = Guid.NewGuid();
            result.DateCreated = DateTime.UtcNow;
            result.CreatedBy = "Root";
            result.LastUpdated = DateTime.UtcNow;
            result.LastUpdatedBy = "Root";
            return result;
        }
        private BaseEquipment ParseEquipment(EquipmentDto equipment)
        {
            var result = _mapper.Map<BaseEquipment>(equipment);
            result.Id = Guid.NewGuid();
            result.DateCreated = DateTime.UtcNow;
            result.CreatedBy = "Root";
            result.LastUpdated = DateTime.UtcNow;
            result.LastUpdatedBy = "Root";
            return result;
        }
    }
}