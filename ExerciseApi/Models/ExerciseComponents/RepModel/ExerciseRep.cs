using System;
using ExerciseApi.Models.Components;
using ExerciseApi.Models.ExerciseComponents.StepModel;
namespace ExerciseApi.Models.ExerciseComponents.RepModel
{
	public class ExerciseRep:Component
	{
	
		public List<ExerciseStepFacade>? Steps { get; set; }
		public bool Completed { get; set; }
		public bool PerformConcurrently { get; set; }
	}
}

