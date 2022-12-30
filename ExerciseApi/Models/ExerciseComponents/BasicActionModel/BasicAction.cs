using System;
using ExerciseApi.Models.Components;
using ExerciseApi.Models.Equipment;
namespace ExerciseApi.Models.ExerciseComponents.BasicActionModel
{
	/*
	 * Represents a simple action, such as holding 2 dumbbell and move from left to right
	 */
	public class BasicAction: Component
	{
		public String? Instruction { get; set; }
		public BaseEquipment? Equipment { get; set; }
	}
}

