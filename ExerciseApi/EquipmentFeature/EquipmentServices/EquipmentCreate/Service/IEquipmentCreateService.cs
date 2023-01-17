using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.EquipmentFeature.Models.Dto;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Service
{
    public interface IEquipmentCreateService
    {
        public Task<OperationResult<EquipmentEntity>> CreateEquipmentAsync(EquipmentDto entity);
        public Task<OperationResult<List<EquipmentEntity>>> CreateMultipleEquipmentAsync(List<EquipmentDto> equipmentList);
    }
}