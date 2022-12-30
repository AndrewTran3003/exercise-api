using System;
using ExerciseApi.Models.Components;
using System.ComponentModel.DataAnnotations;

namespace ExerciseApi.Models.ExerciseComponents.StepModel
{
	public class ExerciseStepFacade:FacadeComponent
	{
		[Required]
		public ExerciseStep? Step { get; set; }
	}
}

