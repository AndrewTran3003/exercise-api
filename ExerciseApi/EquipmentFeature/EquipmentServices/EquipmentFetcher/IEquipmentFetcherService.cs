using ExerciseApi.EquipmentFeature.Models;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher
{
    public interface IEquipmentFetcherService
    {
        public EquipmentEntity GetEquipmentById(string equipmentId);
        public List<EquipmentEntity> GetAllEquipments();
    }
}
