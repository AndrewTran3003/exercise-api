using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.EquipmentFeature.Models.Dto;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Repository
{
    public interface IEquipmentUpdateRepository
    {
        public Task<OperationResult<object>> UpdateAsync(EquipmentDto equipment);
        public Task<OperationResult<object>> UpdateMultipleAsync(List<EquipmentDto> equipmentList);
        public Task<bool> EquipmentExitsAsync (EquipmentDto equipment);
        public Task<bool> EquipmentsExistAsync (List<EquipmentDto> equipmentList);
    }
}