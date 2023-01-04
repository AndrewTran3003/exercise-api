using ExerciseApi.Models;
using ExerciseApi.Models.Equipment;
using ExerciseApi.Models.ExerciseComponents.ExerciseModel;
using ExerciseApi.Models.ExerciseComponents.BasicActionModel;
using ExerciseApi.Models.ExerciseComponents.StepModel;
using ExerciseApi.Models.ExerciseComponents.RepModel;
using ExerciseApi.Models.Components;
using ExerciseApi.Models.Time;
using ExerciseApi.Models.Break;
namespace ExerciseApi.Data
{
	public static class DataSeeding
	{
		public static WorkoutDay GetWorkoutDay()
		{
			return new WorkoutDay
			{
				Id = Guid.NewGuid(),
				DateTaken = DateTime.Now,
				Name = "Monday's workout",
				Description = "My monday workout",
				Completed = false,
				Exercises = new List<ExerciseFacade>{
					TreadmillExerciseFacade()
				}
			};
		}

		#region Exercise
		public static Exercise TreadmillExercise(){
			return new Exercise {
				Id = Guid.NewGuid(),
				Name = "Treadmill Exercise",
				Description = "The standard treadmill exercise that should be performed at the beginning of the exercise",
				ExerciseSet = new List<ExerciseRepFacade> {
					RunOnTreadmillRepFacade()
				}
			};
		}
		public static ExerciseFacade TreadmillExerciseFacade(){
			return new ExerciseFacade{
				Id = Guid.NewGuid(),
				Exercise = TreadmillExercise(),
			};
		}
		#endregion
		#region Rep
		public static ExerciseRepFacade RunOnTreadmillRepFacade(){
			return new ExerciseRepFacade {
				Id = Guid.NewGuid(),
				Rep = RunOnTreadmillRep(),
				Timeline = new List<TimeComponent> {
					ActiveTime_16mins(),
					WarmupBreak_2mins(),
				}
			};
		}
		public static ExerciseRep RunOnTreadmillRep(){
			return new ExerciseRep {
				Id = Guid.NewGuid(),
				Name = "RunOnTreadmillRep",
				Description = "RunOnTreadmillRep",
				Steps = new List<ExerciseStepFacade>{
					HangTowelFacade(),
					RunOnTreadMillStepFacade(),
					CoolDownStepFacade(),
					WipeupStepFacade()
				},
				PerformConcurrently = false,
			};
		}
		#endregion
		#region Step
		public static ExerciseStep CoolDownStep(){
			return new ExerciseStep{
				Id = Guid.NewGuid(),
				Name = "CoolDownStep",
				Description = "CoolDownStep",
				Actions = new List<BasicActionFacade> {
					CoolDownAction(),
				},
				PerformConcurrently = false
			};
		}
		public static ExerciseStepFacade CoolDownStepFacade(){
			return new ExerciseStepFacade{
				Id = Guid.NewGuid(),
				Step = CoolDownStep(),
				Timeline = null
			};
		}
		public static ExerciseStep RunOnTreadmillStep(){
			return new ExerciseStep{
				Id = Guid.NewGuid(),
				Name = "RunOnTreadmillStep",
				Description = "RunOnTreadmillStep",
				Actions = new List<BasicActionFacade> {
					RunOnTreadmillAction(),
				},
				PerformConcurrently = false
			};
		}
		public static ExerciseStepFacade RunOnTreadMillStepFacade(){
			return new ExerciseStepFacade{
				Id = Guid.NewGuid(),
				Step = RunOnTreadmillStep(),
				Timeline = null
			};
		}
		public static ExerciseStep HangTowelStep(){
			return new ExerciseStep{
				Id = Guid.NewGuid(),
				Name = "HangTowel",
				Description = "HangTowel",
				Actions = new List<BasicActionFacade> {
					PutTowelToTheSideAction(),
				},
				PerformConcurrently = false
			};
		}
		public static ExerciseStepFacade HangTowelFacade(){
			return new ExerciseStepFacade{
				Id = Guid.NewGuid(),
				Step = HangTowelStep(),
				Timeline = null
			};
		}

		public static ExerciseStep WipeUpStep(){
			return new ExerciseStep{
				Id = Guid.NewGuid(),
				Name = "Wipeup",
				Description = "wipeup",
				Actions = new List<BasicActionFacade> {
					WipeUpAction(),
				},
				PerformConcurrently = false
			};
		}
		public static ExerciseStepFacade WipeupStepFacade(){
			return new ExerciseStepFacade{
				Id = Guid.NewGuid(),
				Step = WipeUpStep(),
				Timeline = null
			}; 
		}

		#endregion
		#region Actions
		public static BasicActionFacade WipeUpAction(){
			return new BasicActionFacade {
				Id = Guid.NewGuid(),
				BasicAction = WipeUp(),
				Timeline = new List<TimeComponent>(){
					Wipeup_1min(),
				}
			};
		}
		public static BasicAction WipeUp(){
			return new BasicAction{
				Id = Guid.NewGuid(),
				Name = "Wipeup",
				Description = "Wipe everything",
				Instruction = "Wipe yourself and the treadmill",
				Equipment = Towel()
			};
		}
		public static BasicActionFacade CoolDownAction(){
			return new BasicActionFacade{
				Id = Guid.NewGuid(),
				BasicAction = CoolDown(),
				Timeline = new List<TimeComponent>(){
					WorkoutTime_5mins()
				}
			};
		}
		public static BasicAction CoolDown(){
			return new BasicAction {
				Id = Guid.NewGuid(),
				Name = "CoolDown",
				Description = "CoolDown by walking on the treadmill",
				Instruction = "Walk on the treadmill at 4 km/h",
				Equipment = Treadmill()
			};
		}
		public static BasicActionFacade RunOnTreadmillAction(){
			return new BasicActionFacade{
				Id = Guid.NewGuid(),
				BasicAction = RunOnTreadmill(),
				Timeline = new List<TimeComponent>(){
					WorkoutTime_10mins()
				}
			};
		}
		public static BasicAction RunOnTreadmill(){
			return new BasicAction {
				Id = Guid.NewGuid(),
				Name = "Treadmill running",
				Description = "Treadmill running exercise",
				Instruction = "Run on the treadmill at 8 km/h",
				Equipment = Treadmill()

			};
		}

		public static BasicActionFacade PutTowelToTheSideAction(){
			return new BasicActionFacade{
				Id = Guid.NewGuid(),
				BasicAction = PutTowelToTheSide(),
				Timeline = null
			};
		}
		public static BasicAction PutTowelToTheSide(){
			return new BasicAction {
				Id = Guid.NewGuid(),
				Name = "Put Towel To The Side",
				Description = "Put Towel To The Side",
				Instruction = @"If you are left handed, put the towel to your right side
							   If you are right handed, put the towel to your left side",
				Equipment = Towel()

			};
		}

		#endregion
		#region Time
		public static StartTime WorkoutTime_10mins(){
			return new StartTime {
				Id = Guid.NewGuid(),
				Name = "Workout-10mins",
				Description = "Work out for 10 minutes",
				Duration = new TimeSpan(0,10,0)
			};
		}
		public static StartTime WorkoutTime_5mins(){
			return new StartTime {
				Id = Guid.NewGuid(),
				Name = "Workout-5mins",
				Description = "Work out for 5 minutes",
				Duration = new TimeSpan(0,5,0)
			};
		}
		public static StartTime Wipeup_1min(){
			return new StartTime {
				Id = Guid.NewGuid(),
				Name = "Wipeup_1min",
				Description = "Wipe for 1 min",
				Duration = new TimeSpan(0,1,0)
			};
		}
		public static BasicBreak WarmupBreak_2mins(){
			return new BasicBreak {
				Id = Guid.NewGuid(),
				Name = "Warmup break 2 mins",
				Description = "Take a short break after warming up for 2 minutes",
				Duration = new TimeSpan(0,2,0)
			};
		}
		public static StartTime ActiveTime_16mins () {
			return new StartTime {
				Id = Guid.NewGuid(),
				Name = "Wipeup_1min",
				Description = "Wipe for 1 min",
				Duration = new TimeSpan(0,16,0)
			};
		}

		#endregion
        #region Equipment
        public static BaseEquipment Treadmill()
		{
			return new BaseEquipment
			{
				Id = Guid.NewGuid(),
				Name = "Treadmill",
				Description = "This is a treadmill",
				Price = 999.99
			};
		}
		public static BaseEquipment Towel()
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

