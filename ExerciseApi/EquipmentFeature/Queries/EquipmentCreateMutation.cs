using System;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Service;
using ExerciseApi.EquipmentFeature.Models.Dto;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;
using ExerciseApi.Queries;

namespace ExerciseApi.EquipmentFeature.Queries
{
	[ExtendObjectType(nameof(Mutation))]
	public class EquipmentCreateMutation
	{
		private readonly IEquipmentCreateService _service;
		public EquipmentCreateMutation(IEquipmentCreateService service)
		{
			_service = service;
		}
		public async Task<OperationResult<EquipmentEntity>> CreateOne(EquipmentDto equipment)
		{
			return await _service.CreateEquipmentAsync(equipment);
		}
	}
}

