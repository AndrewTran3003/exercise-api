using System;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Service;
using ExerciseApi.EquipmentFeature.Models.Dto;
using ExerciseApi.Helpers;
using ExerciseApi.Queries;

namespace ExerciseApi.EquipmentFeature.Queries
{
    [ExtendObjectType(nameof(Mutation))]
    public class EquipmentUpdateMutation
	{
		private readonly IEquipmentUpdateService _service;
		public EquipmentUpdateMutation (IEquipmentUpdateService service)
		{
			_service = service;
		}

		[GraphQLName("UpdateOneEquipment")]
		public async Task<OperationResult<object>> UpdateAsync (EquipmentDto equipment)
		{
			return await _service.UpdateEquipmentAsync(equipment);
		}

        [GraphQLName("UpdateMultipleEquipments")]
        public async Task<OperationResult<object>> UpdateMultipleAsync (List<EquipmentDto> equipmentList)
		{
			return await _service.UpdateEquipmentMulitpleAsync(equipmentList);
		}
	}
}

