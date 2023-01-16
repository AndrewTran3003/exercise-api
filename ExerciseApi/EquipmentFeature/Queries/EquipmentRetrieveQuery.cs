using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Service;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.Queries {
    public class EquipmentRetrieveQuery{
        private readonly IEquipmentFetcherService _equipmentFetcher;
        public EquipmentRetrieveQuery(IEquipmentFetcherService equipmentFetcher) {
            _equipmentFetcher = equipmentFetcher;
        }
        public async Task<List<EquipmentEntity>?> GetEquipments(){
              var result = await _equipmentFetcher.GetAllEquipmentsAsync();
              return result.Status == OperationStatus.Success ? result.Result : null;
        }
    }
}