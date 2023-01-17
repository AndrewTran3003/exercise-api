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

		[GraphQLName("CreateOneEquipment")]
		public async Task<OperationResult<EquipmentEntity>> CreateOneEquipmentAsync(EquipmentDto equipment)
		{
			return await _service.CreateEquipmentAsync(equipment);
		}

		[GraphQLName("CreateManyEquipment")]
		public async Task<OperationResult<List<EquipmentEntity>>> CreateManyEquipmentsAsync(List<EquipmentDto> equipmentList)
		{
			return await _service.CreateMultipleEquipmentAsync(equipmentList);
		}
	}
}

