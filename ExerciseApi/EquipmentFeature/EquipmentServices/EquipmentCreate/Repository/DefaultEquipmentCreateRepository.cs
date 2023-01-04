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
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EquipmentEntity, BaseEquipment>());
            _mapper = config.CreateMapper();
            _context = context;
        }
        public async Task<OperationResult<EquipmentEntity>> CreateAsync(EquipmentEntity equipment)
        {
            var result = _mapper.Map<BaseEquipment>(equipment);
            result.Id = Guid.NewGuid();
            _context.BaseEquipments.Add(result);
            await _context.SaveChangesAsync();
            equipment.Id = result.Id;
            return new OperationResult<EquipmentEntity>(OperationStatus.Success, String.Empty, equipment);
        }
    }
}