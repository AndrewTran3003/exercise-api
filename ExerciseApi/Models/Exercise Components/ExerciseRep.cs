using System;
namespace ExerciseApi.Models.ExerciseComponents
{
	public class ExerciseRep
	{
		public List<ExerciseStep>? Steps { get; set; }
		public bool Completed { get; set; }
	}
}

