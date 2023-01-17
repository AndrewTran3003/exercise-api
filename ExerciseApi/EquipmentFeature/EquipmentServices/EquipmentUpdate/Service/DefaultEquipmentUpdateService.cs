using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Service;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Repository;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.EquipmentFeature.Models.Dto;
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
        public async Task<OperationResult<object>> UpdateEquipmentAsync(EquipmentDto equipment)
        {
            if (equipment == null)
            {
                return new OperationResult<object>(OperationStatus.Error, "Equipment is empty", null);
            }
            if (CheckIdNull(equipment).Status != OperationStatus.Success)
            {
                return new OperationResult<object>(OperationStatus.Error, "The Id is required", null);
            }
            if (!await _repo.EquipmentExitsAsync(equipment))
            {
                return new OperationResult<object>(OperationStatus.NotFound, $"There is no equipment with Id {equipment.Id.ToString()}", null);
            }
            return await _repo.UpdateAsync(equipment);
        }

        public async Task<OperationResult<object>> UpdateEquipmentMulitpleAsync(List<EquipmentDto> equipmentList)
        {
            if (equipmentList == null)
            {
                return new OperationResult<object>(OperationStatus.Error, "Equipment List is empty", null);
            }
            if (CheckIdNullList(equipmentList).Status != OperationStatus.Success)
            {
                return new OperationResult<object>(OperationStatus.Error, "An Equipment Id is missing from the list", null);
            }
            if (!await _repo.EquipmentsExistAsync(equipmentList))
            {
                return new OperationResult<object>(OperationStatus.NotFound, "An equipment with Id that does not exist is in the list", null);
            }
            return await _repo.UpdateMultipleAsync(equipmentList);
        }

        private OperationResult<object> CheckIdNullList(List<EquipmentDto> equipmentList)
        {
            foreach (EquipmentDto equipment in equipmentList)
            {
                var checkResult = CheckIdNull(equipment);
                if (checkResult.Status != OperationStatus.Success)
                {
                    return new OperationResult<object>(OperationStatus.Error, "Equipment List is empty", null);
                }
            }
            return new OperationResult<object>(OperationStatus.Success, String.Empty, null);
        }

        private OperationResult<object> CheckIdNull(EquipmentDto equipment)
        {
            var equipmentIdString = equipment.Id.ToString();
            return String.IsNullOrEmpty(equipment.Id.ToString()) || String.IsNullOrWhiteSpace(equipment.Id.ToString())
                ? new OperationResult<object>(OperationStatus.Error, "Equipment Id is missing", null)
                : new OperationResult<object>(OperationStatus.Success, String.Empty, null);
        }
    }
}