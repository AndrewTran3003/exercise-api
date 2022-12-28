using System;
using ExerciseApi.Models;
using ExerciseApi.Models.ExerciseComponents;
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
            modelBuilder.Entity<WorkoutDay>(e => e.ToTable("workoutday"));
			modelBuilder.Entity<Exercise>(e => e.ToTable("exercise"));
			modelBuilder.Entity<Break>(e => e.ToTable("break"));
			modelBuilder.Entity<Equipment>(e => e.ToTable("equiment"));
			modelBuilder.Entity<ExerciseRep>(e => e.ToTable("exerciserep"));
			modelBuilder.Entity<ExerciseStep>(e => e.ToTable("exercisestep"));
			modelBuilder.Entity<Equipment>(e => e.ToTable("equipment"));
			base.OnModelCreating(modelBuilder);

		}

        private const string CONNECTION_STRING = "Host=localhost;" +
            "Port=5432;" +
            "Username=exercise-admin;" +
            "Password=1234;" +
            "Database=exerciseDb";
    }
}

