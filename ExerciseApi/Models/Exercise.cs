using System;
using ExerciseApi.Models.ExerciseComponents;
namespace ExerciseApi.Models
{
	public class Exercise:ExerciseComponent
	{
		public List<Equipment>? Equipments { get; set; }
		public List<ExerciseRep>? ExerciseSet { get; set; }
		public DateTime Duration { get; set; }
		public bool Completed { get; set; }
	}
}
