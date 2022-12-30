using System;
using ExerciseApi.Models.ExerciseComponents.RepModel;
using ExerciseApi.Models.Components;
namespace ExerciseApi.Models.ExerciseComponents.ExerciseModel
{
	public class Exercise : Component
	{
		public List<ExerciseRepFacade>? ExerciseSet { get; set; }
        public bool PerformConcurrently { get; set; }
        public bool Completed { get; set; }
    }
}
