using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Repository;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Service
{
    public class DefaultEquipmentCreateService : IEquipmentCreateService
    {
        private readonly IEquipmentCreateRepository _repo;
        public DefaultEquipmentCreateService(IEquipmentCreateRepository repo)
        {
            _repo = repo;
        }
        public async Task<OperationResult<EquipmentEntity>> CreateEquipmentAsync(EquipmentEntity entity)
        {
            var result = await _repo.CreateAsync(entity);
            return result;
        }
    }
}