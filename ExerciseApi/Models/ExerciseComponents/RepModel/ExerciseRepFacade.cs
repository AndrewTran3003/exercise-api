using System;
using ExerciseApi.Models.Components;
using System.ComponentModel.DataAnnotations;

namespace ExerciseApi.Models.ExerciseComponents.RepModel
{
	public class ExerciseRepFacade: FacadeComponent
	{
        [Required]
        public ExerciseRep? Rep { get; set; }
    }
}

