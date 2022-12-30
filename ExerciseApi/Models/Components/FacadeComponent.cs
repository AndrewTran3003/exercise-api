using System;
using System.ComponentModel.DataAnnotations;

namespace ExerciseApi.Models.Components
{
	public class FacadeComponent
	{
        public Guid Id { get; set; }
        [Required]
        public List<TimeComponent>? Timeline { get; set; }
        public bool Completed { get; set; }
    }
}

