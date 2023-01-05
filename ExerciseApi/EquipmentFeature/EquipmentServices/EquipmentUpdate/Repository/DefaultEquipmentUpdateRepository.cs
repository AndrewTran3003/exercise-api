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
        public async Task<OperationResult<object>> UpdateAsync(EquipmentEntity equipment)
        {
            try
            {
                _context.BaseEquipments.Update(_mapper.Map<BaseEquipment>(equipment));
                await _context.SaveChangesAsync();
                return new OperationResult<object>(OperationStatus.Success, "Item updated", null);
            }
            catch (Exception e)
            {
                return new OperationResult<object>(OperationStatus.Error, e.Message, null);
            }
        }
    }
}