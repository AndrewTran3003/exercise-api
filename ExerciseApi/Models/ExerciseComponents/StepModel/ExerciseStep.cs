using System;
using ExerciseApi.Models.ExerciseComponents.BasicActionModel;
using ExerciseApi.Models.Components;
namespace ExerciseApi.Models.ExerciseComponents.StepModel
{
	public class ExerciseStep:Component
	{
		public List<BasicActionFacade>? Actions { get; set; }
		public bool PerformConcurrently { get; set; }
		public bool Completed { get; set; }
	}
}

