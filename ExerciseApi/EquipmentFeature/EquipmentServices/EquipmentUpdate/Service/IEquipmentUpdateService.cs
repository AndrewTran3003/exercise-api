using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Service
{
    public interface IEquipmentUpdateService
    {
        public Task<OperationResult<object>> UpdateEquipmentAsync(EquipmentEntity equipment);
        public Task<OperationResult<object>> UpdateEquipmentMulitpleAsync(List<EquipmentEntity> equipmentList);
    }
}