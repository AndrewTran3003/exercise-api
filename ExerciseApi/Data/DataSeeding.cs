using System;
using ExerciseApi.Models;
using ExerciseApi.Models.Equipment;
using ExerciseApi.Models.ExerciseComponents.ExerciseModel;

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
				DateTaken = DateTime.Now,
				Name = "Monday's workout",
				Description = "My monday workout",
				Completed = false,
				Exercises = null
			};

		}



        private Exercise TreadmillRunning()
		{
			return new Exercise
            {
				Id = Guid.NewGuid(),
				Name = "Treadmill running",
				Description = "Warm up treadmill running",
			};
		}
        #region Equipment
        private BaseEquipment Treadmill()
		{
			return new BaseEquipment
			{
				Id = Guid.NewGuid(),
				Name = "Treadmill",
				Description = "This is a treadmill",
				Price = 999.99
			};
		}
		private BaseEquipment Towel()
		{
            return new BaseEquipment
            {
                Id = Guid.NewGuid(),
                Name = "Towel",
                Description = "Plain white towel",
                Price = 4.0
            };
        }
        #endregion
    }
}

