using AutoMapper;
using ExerciseApi.Data;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;
using ExerciseApi.Models.Equipment;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Repository
{
    public class DefaultEquipmentCreateRepository : IEquipmentCreateRepository
    {
        private readonly ExerciseApiDbContext _context;
        private readonly IMapper _mapper;

        public DefaultEquipmentCreateRepository(ExerciseApiDbContext context)
        {
            _mapper = CreateMapper();
            _context = context;
        }
        public async Task<OperationResult<EquipmentEntity>> CreateAsync(EquipmentEntity equipment)
        {
            try
            {
                var baseEquipment = ParseBasedEquipment(equipment);
                await _context.BaseEquipments.AddAsync(baseEquipment);
                await _context.SaveChangesAsync();
                var createdEquipment = GetCreatedEquipment();
                return new OperationResult<EquipmentEntity>(OperationStatus.Success, String.Empty, createdEquipment);
            }
            catch (Exception e)
            {
                return new OperationResult<EquipmentEntity>(OperationStatus.ServerError, e.Message, null);
            }

        }

        public async Task<OperationResult<List<EquipmentEntity>>> CreateListAsync(List<EquipmentEntity> equipmentList)
        {
            try
            {
                var baseEquipmentList = ParseBaseEquipmenttList(equipmentList);
                await _context.BaseEquipments.AddRangeAsync(baseEquipmentList);
                await _context.SaveChangesAsync();
                var createdEquipments = GetCreatedEquipments(equipmentList.Count);
                return new OperationResult<List<EquipmentEntity>>(OperationStatus.Success, String.Empty, createdEquipments);
            }
            catch (Exception e)
            {
                return new OperationResult<List<EquipmentEntity>>(OperationStatus.ServerError, e.Message, null);
            }
        }

        private EquipmentEntity GetCreatedEquipment()
        {
            return _mapper.Map<EquipmentEntity>(
                _context.BaseEquipments.OrderBy(e => e.Id).Last()
            );
        }

        private List<EquipmentEntity> GetCreatedEquipments(int number)
        {
            return _context.BaseEquipments
                            .OrderByDescending(e => e.Id)
                            .Take(number)
                            .OrderBy(e => e.Id)
                            .Select(e => _mapper.Map<EquipmentEntity>(e))
                            .ToList();
        }

        private IMapper CreateMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EquipmentEntity, BaseEquipment>();
                cfg.CreateMap<BaseEquipment, EquipmentEntity>();
            })
            .CreateMapper();
        }

        private List<BaseEquipment> ParseBaseEquipmenttList(List<EquipmentEntity> equipmentList)
        {
            return equipmentList.Select(e => ParseBasedEquipment(e))
                                .ToList();
        }

        private BaseEquipment ParseBasedEquipment(EquipmentEntity equipment)
        {
            var result = _mapper.Map<BaseEquipment>(equipment);
            result.Id = Guid.NewGuid();
            return result;
        }
    }
}