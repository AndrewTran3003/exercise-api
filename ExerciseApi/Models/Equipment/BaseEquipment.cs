using System;
namespace ExerciseApi.Models.Equipment;

public class BaseEquipment
{
	public Guid Id { get; set; }
	public String? Name { get; set; }
	public String? Description { get; set; }
	public double Price { get; set; }
}

