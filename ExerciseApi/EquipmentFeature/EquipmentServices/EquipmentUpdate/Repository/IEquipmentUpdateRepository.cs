using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Repository
{
    public interface IEquipmentUpdateRepository
    {
        public Task<OperationResult<object>> UpdateAsync(EquipmentEntity equipment);
        public Task<OperationResult<object>> UpdateMultipleAsync(List<EquipmentEntity> equipmentList);
        public bool EquipmentExits(EquipmentEntity equipment);
        public bool EquipmentsExist(List<EquipmentEntity> equipmentList);
    }
}