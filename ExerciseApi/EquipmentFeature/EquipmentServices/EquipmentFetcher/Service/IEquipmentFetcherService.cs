using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Service
{
    public interface IEquipmentFetcherService
    {
        public Task<OperationResult<EquipmentEntity>> GetEquipmentByIdAsync(string equipmentId);
        public Task<OperationResult<List<EquipmentEntity>>> GetAllEquipmentsAsync();
    }
}
