using System;
namespace ExerciseApi.Models
{
	public class ExerciseComponent
	{
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float Duration { get; set; }
    }
}

