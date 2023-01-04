using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Service
{
    public interface IEquipmentFetcherService
    {
        public OperationResult<EquipmentEntity> GetEquipmentById(string equipmentId);
        public OperationResult<List<EquipmentEntity>> GetAllEquipments();
    }
}