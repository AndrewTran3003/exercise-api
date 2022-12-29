using System;
using ExerciseApi.Models.ExerciseComponents;

namespace ExerciseApi.Models
{
	public class Break:ExerciseComponent
	{
		public List<ExerciseRep>? BreakSequence { get; set; }
	}
}

