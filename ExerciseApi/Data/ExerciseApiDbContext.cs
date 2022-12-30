﻿using System;
using ExerciseApi.Models;
using ExerciseApi.Models.ExerciseComponents;
using ExerciseApi.Models.ExerciseComponents.ExerciseModel;
using ExerciseApi.Models.ExerciseComponents.RepModel;
using ExerciseApi.Models.ExerciseComponents.StepModel;
using ExerciseApi.Models.ExerciseComponents.BasicActionModel;
using ExerciseApi.Models.Equipment;
using ExerciseApi.Models.Time;

using Microsoft.EntityFrameworkCore;

namespace ExerciseApi.Data
{
	public class ExerciseApiDbContext:DbContext
	{
		public DbSet<WorkoutDay> WorkoutDays { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(CONNECTION_STRING);
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<WorkoutDay>(e => e.ToTable("WorkoutDay"));
			modelBuilder.Entity<Exercise>(e => e.ToTable("Exercise"));
			modelBuilder.Entity<ExerciseFacade>(e => e.ToTable("ExerciseFacade"));
			modelBuilder.Entity<ExerciseRep>(e => e.ToTable("ExerciseRep"));
			modelBuilder.Entity<ExerciseRepFacade>(e => e.ToTable("ExerciseRepFacade"));
			modelBuilder.Entity<ExerciseStep>(e => e.ToTable("ExerciseStep"));
			modelBuilder.Entity<ExerciseStepFacade>(e => e.ToTable("ExerciseStepFacade"));
			modelBuilder.Entity<BasicAction>(e => e.ToTable("BasicAction"));
			modelBuilder.Entity<BasicActionFacade>(e => e.ToTable("BasicActionFacade"));

			modelBuilder.Entity<BasicBreak>(e => e.ToTable("BasicBreak"));
			modelBuilder.Entity<BreakWithActions>(e => e.ToTable("BreakWithActions"));
			modelBuilder.Entity<BaseEquipment>(e => e.ToTable("BaseEquiment"));

			modelBuilder.Entity<StartTime>(e => e.ToTable("StartTime"));
			modelBuilder.Entity<StopTime>(e => e.ToTable("StopTime"));
			base.OnModelCreating(modelBuilder);

		}

        private const string CONNECTION_STRING = "Host=localhost;" +
            "Port=5432;" +
            "Username=exercise-admin;" +
            "Password=1234;" +
            "Database=exerciseDb";
    }
}

