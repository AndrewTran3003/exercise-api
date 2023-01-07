using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Repository
{
    public interface IEquipmentCreateRepository
    {
        public Task<OperationResult<EquipmentEntity>> CreateAsync(EquipmentEntity equipment);
        public Task<OperationResult<List<EquipmentEntity>>> CreateListAsync(List<EquipmentEntity> equipmentList);
    }
}