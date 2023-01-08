using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerciseApi.Migrations
{
    /// <inheritdoc />
    public partial class addauditinformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "WorkoutDays",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "WorkoutDays",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "TimeComponent",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "TimeComponent",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "ExerciseSteps",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "ExerciseSteps",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Exercises",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "Exercises",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "ExerciseReps",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "ExerciseReps",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "BasicActions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "BasicActions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "BaseEquipments",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "BaseEquipments",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "WorkoutDays");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "WorkoutDays");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "TimeComponent");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "TimeComponent");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "ExerciseSteps");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "ExerciseSteps");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "ExerciseReps");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "ExerciseReps");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "BasicActions");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "BasicActions");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "BaseEquipments");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "BaseEquipments");
        }
    }
}
