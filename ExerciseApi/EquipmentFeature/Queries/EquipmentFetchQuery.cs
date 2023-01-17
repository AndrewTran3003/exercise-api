using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Service;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Service;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;
using ExerciseApi.Queries;

namespace ExerciseApi.EquipmentFeature.Queries {
    [ExtendObjectType(nameof(Query))]
    public class EquipmentFetchQuery{
        private readonly IEquipmentFetcherService _equipmentFetcher;
        public EquipmentFetchQuery(IEquipmentFetcherService equipmentFetcher) {
            _equipmentFetcher = equipmentFetcher;
        }
        public async Task<OperationResult<List<EquipmentEntity>?>> GetEquipments([Parent] Query query){
              return await _equipmentFetcher.GetAllEquipmentsAsync();

        }
        public async Task<OperationResult<EquipmentEntity?>> GetEquipment([Parent] Query query, string equipmentId)
        {
            return await _equipmentFetcher.GetEquipmentByIdAsync(equipmentId);
            
        }
    }
}