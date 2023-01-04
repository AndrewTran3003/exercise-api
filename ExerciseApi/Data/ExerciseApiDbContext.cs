using System;
using ExerciseApi.Models;
using ExerciseApi.Models.Break;
using ExerciseApi.Models.ExerciseComponents.ExerciseModel;
using ExerciseApi.Models.ExerciseComponents.RepModel;
using ExerciseApi.Models.ExerciseComponents.StepModel;
using ExerciseApi.Models.ExerciseComponents.BasicActionModel;
using ExerciseApi.Models.Equipment;
using ExerciseApi.Models.Time;

using Microsoft.EntityFrameworkCore;

namespace ExerciseApi.Data
{
    public class ExerciseApiDbContext : DbContext
    {
        public DbSet<WorkoutDay>? WorkoutDays { get; set; }
        public DbSet<Exercise>? Exercises { get; set; }
        public DbSet<ExerciseFacade>? ExerciseFacades { get; set; }
        public DbSet<ExerciseRep>? ExerciseReps { get; set; }
        public DbSet<ExerciseRepFacade>? ExerciseRepFacades { get; set; }
        public DbSet<ExerciseStep>? ExerciseSteps { get; set; }
        public DbSet<ExerciseStepFacade>? ExerciseStepFacades { get; set; }
        public DbSet<BasicAction>? BasicActions { get; set; }
        public DbSet<BasicActionFacade>? BasicActionFacades { get; set; }
        public DbSet<BasicBreak>? BasicBreaks { get; set; }
        public DbSet<BreakWithActions>? BreakWithActions { get; set; }
        public DbSet<BaseEquipment>? BaseEquipments { get; set; }
        public DbSet<StartTime>? StartTimes { get; set; }
        public DbSet<StopTime>? StopTimes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(CONNECTION_STRING);
            base.OnConfiguring(optionsBuilder);
        }
        private const string CONNECTION_STRING = "Host=localhost;" +
            "Port=5432;" +
            "Username=exercise-admin;" +
            "Password=1234;" +
            "Database=exerciseDb";
    }
}

