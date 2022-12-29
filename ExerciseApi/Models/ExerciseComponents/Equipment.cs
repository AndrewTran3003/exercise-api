using System;
namespace ExerciseApi.Models.ExerciseComponents
{
	public class Equipment
	{
		public Guid Id { get; set; }
		public String? Name { get; set; }
		public String? Description { get; set; }
		public double Price { get; set; }
	}
}

