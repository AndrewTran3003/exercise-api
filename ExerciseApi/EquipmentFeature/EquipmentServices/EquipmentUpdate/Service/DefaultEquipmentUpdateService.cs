using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Service;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Repository;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Service
{
    public class DefaultEquipmentUpdateService : IEquipmentUpdateService
    {
        private readonly IEquipmentUpdateRepository _repo;
        public DefaultEquipmentUpdateService(
            IEquipmentUpdateRepository repo)
        {
            _repo = repo;
        }
        public async Task<OperationResult<object>> UpdateEquipmentAsync(EquipmentEntity equipment)
        {
            if (equipment == null)
            {
                return new OperationResult<object>(OperationStatus.Error, "Equipment is empty", null);
            }
            if (String.IsNullOrEmpty(equipment.Id.ToString()) || String.IsNullOrWhiteSpace(equipment.Id.ToString()))
            {
                return new OperationResult<object>(OperationStatus.Error, "The Id is required", null);
            }           
            if (!_repo.EquipmentExits(equipment))
            {
                return new OperationResult<object>(OperationStatus.NotFound, $"There is no equipment with Id {equipment.Id.ToString()}", null);
            }
            return await _repo.UpdateAsync(equipment);
        }
    }
}