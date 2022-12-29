using System;
using ExerciseApi.Models;
using ExerciseApi.Models.ExerciseComponents;

namespace ExerciseApi.Data
{
	public class DataSeeding
	{
		private readonly Guid _workoutDayId;
		private readonly Guid _exerciseId;
		private readonly Guid _breakId;

		public DataSeeding()
		{
			_workoutDayId = Guid.NewGuid();
			_exerciseId = Guid.NewGuid();
			_breakId = Guid.NewGuid();
		}

		public WorkoutDay GetWorkoutDay()
		{
			return new WorkoutDay
			{
				Id = _workoutDayId,
				Date = DateTime.Now,
				Name = "Monday's workout",
				Description = "My monday workout",
				Completed = false,
				WorkoutPlan = GetWorkoutPlan()
			};

		}

		public List<ExerciseComponent> GetWorkoutPlan()
		{
			return new List<ExerciseComponent>()
			{

			};
		}
		private Exercise TreadmillRunning()
		{
			return new Exercise
			{
				Id = Guid.NewGuid(),
				Name = "Treadmill running",
				Description = "Warm up treadmill running",
				Duration = 10,
				Equipments = new List<Equipment>()
				{
					Treadmill(),
					Towel()
				}


			};
		}
		private Equipment Treadmill()
		{
			return new Equipment
			{
				Id = Guid.NewGuid(),
				Name = "Treadmill",
				Description = "This is a treadmill",
				Price = 999.99
			};
		}
		private Equipment Towel()
		{
            return new Equipment
            {
                Id = Guid.NewGuid(),
                Name = "Towel",
                Description = "Plain white towel",
                Price = 4.0
            };
        }
    }
}

