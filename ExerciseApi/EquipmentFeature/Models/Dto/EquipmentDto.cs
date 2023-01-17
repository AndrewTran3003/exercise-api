using System;
namespace ExerciseApi.EquipmentFeature.Models.Dto
{
	public class EquipmentDto
	{
		public Guid? Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public float? Price { get; set; }
	}
}

