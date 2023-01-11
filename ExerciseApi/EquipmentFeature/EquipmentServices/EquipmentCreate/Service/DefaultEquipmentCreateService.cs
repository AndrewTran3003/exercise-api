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
            return await _repo.CreateAsync(entity);
        }

        public async Task<OperationResult<List<EquipmentEntity>>> CreateMultipleEquipmentAsync(List<EquipmentEntity> equipmentList)
        {
            return await _repo.CreateListAsync(equipmentList);
        }
    }
}