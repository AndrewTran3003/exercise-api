using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Repository
{
    public interface IEquipmentUpdateRepository
    {
        public Task<OperationResult<object>> UpdateAsync(EquipmentEntity equipment);
        public bool EquipmentExits(EquipmentEntity equipment);
    }
}