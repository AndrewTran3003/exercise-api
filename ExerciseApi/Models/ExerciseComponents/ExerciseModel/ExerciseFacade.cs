using System;
using ExerciseApi.Models.Components;
using System.ComponentModel.DataAnnotations;

namespace ExerciseApi.Models.ExerciseComponents.ExerciseModel
{
	public class ExerciseFacade: FacadeComponent
    {
        [Required]
        public Exercise? Exercise { get; set; }
    }
}

