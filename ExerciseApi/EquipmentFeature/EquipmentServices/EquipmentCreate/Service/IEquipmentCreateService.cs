using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Service
{
    public interface IEquipmentCreateService
    {
        public Task<OperationResult<EquipmentEntity>> CreateEquipmentAsync(EquipmentEntity entity);
    }
}