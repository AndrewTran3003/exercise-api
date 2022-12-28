using System;
using ExerciseApi.Models;
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

        private const string CONNECTION_STRING = "Host=localhost;" +
            "Port=5455;" +
            "Username=postgresUser;" +
            "Password=postgresPW;" +
            "Database=postgresDB";
    }
}

