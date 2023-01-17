using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.EquipmentFeature.Models.Dto;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Repository
{
    public interface IEquipmentCreateRepository
    {
        public Task<OperationResult<EquipmentEntity>> CreateAsync(EquipmentDto equipment);
        public Task<OperationResult<List<EquipmentEntity>>> CreateListAsync(List<EquipmentDto> equipmentList);
    }
}