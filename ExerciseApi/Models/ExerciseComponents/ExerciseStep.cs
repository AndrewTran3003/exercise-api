using System;
namespace ExerciseApi.Models.ExerciseComponents
{
	public class ExerciseStep
	{
		public Guid Id { get; set; }
		public List<Equipment>? Equipments { get; set; }
		public String? Description { get; set; }	
	}
}

