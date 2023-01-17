using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Service;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.Queries {
    public class EquipmentRetrieveQuery{
        private readonly IEquipmentFetcherService _equipmentFetcher;
        public EquipmentRetrieveQuery(IEquipmentFetcherService equipmentFetcher) {
            _equipmentFetcher = equipmentFetcher;
        }
        public async Task<OperationResult<List<EquipmentEntity>?>> GetEquipments(){
              return await _equipmentFetcher.GetAllEquipmentsAsync();

        }
        public async Task<OperationResult<EquipmentEntity?>> GetEquipment(string equipmentId)
        {
            return await _equipmentFetcher.GetEquipmentByIdAsync(equipmentId);
            
        }
    }
}