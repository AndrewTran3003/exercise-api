using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.EquipmentFeature.Models.Dto;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Service
{
    public interface IEquipmentUpdateService
    {
        public Task<OperationResult<object>> UpdateEquipmentAsync(EquipmentDto equipment);
        public Task<OperationResult<object>> UpdateEquipmentMulitpleAsync(List<EquipmentDto> equipmentList);
    }
}