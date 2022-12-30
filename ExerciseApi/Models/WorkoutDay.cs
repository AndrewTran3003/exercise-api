using System;
using ExerciseApi.Models.ExerciseComponents.ExerciseModel;
using ExerciseApi.Models.Components;
namespace ExerciseApi.Models
{
	public class WorkoutDay:Component
	{
        public DateTime DateTaken { get; set; }
        public List<ExerciseFacade>? Exercises { get; set; }
        public bool Completed { get; set; }
    }
}

