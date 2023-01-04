using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Repository
{
    public interface IEquipmentFetcherRepository
    {
        public Task<OperationResult<EquipmentEntity>> GetAsync(string equipmentId);
    }
}