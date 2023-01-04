using System;
using System.ComponentModel.DataAnnotations;
using ExerciseApi.Models.Components;
namespace ExerciseApi.Models.ExerciseComponents.BasicActionModel
{
    /*
	 * Acts like a wrapper around a basic action
	 * One ExerciseAction has only one BasicAction
	 * Allows specifying 
	 *	- How long a basic action should happen
	 *  - When it should happen, with the help of Timeline that specify when it should happen and when it should not
	 *  - Whether it is completed
	 */
    public class BasicActionFacade : FacadeComponent
    {
        [Required]
        public BasicAction? BasicAction { get; set; }
    }
}

