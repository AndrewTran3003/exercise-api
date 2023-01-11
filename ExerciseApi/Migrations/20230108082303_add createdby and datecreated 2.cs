using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerciseApi.Migrations
{
    /// <inheritdoc />
    public partial class addcreatedbyanddatecreated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "WorkoutDays",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "WorkoutDays",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TimeComponent",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "TimeComponent",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ExerciseSteps",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ExerciseSteps",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Exercises",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Exercises",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ExerciseReps",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ExerciseReps",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "BasicActions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "BasicActions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "BaseEquipments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "BaseEquipments",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkoutDays");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "WorkoutDays");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TimeComponent");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "TimeComponent");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ExerciseSteps");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ExerciseSteps");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ExerciseReps");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ExerciseReps");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "BasicActions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "BasicActions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "BaseEquipments");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "BaseEquipments");
        }
    }
}
