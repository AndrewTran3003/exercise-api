using System;
using ExerciseApi.Models.ExerciseComponents;

namespace ExerciseApi.Models
{
	public class Break:ExerciseComponent
	{
		public DateTime Duration { get; set; }
		public List<ExerciseRep>? BreakSequence { get; set; }
	}
}

