using System;
namespace ExerciseApi.Models
{
	public class WorkoutDay
	{
        public List<ExerciseComponent>? WorkoutPlan { get; set; }
        public bool Completed { get; set; }
    }
}

