using System;
namespace ExerciseApi.Models
{
	public class WorkoutDay
	{
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public String? Description { get; set; }
        public String? Name { get; set; }
        public List<ExerciseComponent>? WorkoutPlan { get; set; }
        public bool Completed { get; set; }
    }
}

