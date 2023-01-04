using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExerciseApi.Migrations
{
    /// <inheritdoc />
    public partial class testseeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicAction_BaseEquiment_EquipmentId",
                table: "BasicAction");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicActionFacade_BasicAction_BasicActionId",
                table: "BasicActionFacade");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicActionFacade_ExerciseStep_ExerciseStepId",
                table: "BasicActionFacade");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseFacade_Exercise_ExerciseId",
                table: "ExerciseFacade");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseFacade_WorkoutDay_WorkoutDayId",
                table: "ExerciseFacade");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseRepFacade_ExerciseRep_RepId",
                table: "ExerciseRepFacade");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseRepFacade_Exercise_ExerciseId",
                table: "ExerciseRepFacade");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseStepFacade_ExerciseRep_ExerciseRepId",
                table: "ExerciseStepFacade");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseStepFacade_ExerciseStep_StepId",
                table: "ExerciseStepFacade");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_BasicActionFacade_BasicActionFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_ExerciseFacade_ExerciseFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_ExerciseRepFacade_ExerciseRepFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_ExerciseStepFacade_ExerciseStepFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropTable(
                name: "BasicBreak");

            migrationBuilder.DropTable(
                name: "BreakWithActions");

            migrationBuilder.DropTable(
                name: "StartTime");

            migrationBuilder.DropTable(
                name: "StopTime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutDay",
                table: "WorkoutDay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseStepFacade",
                table: "ExerciseStepFacade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseStep",
                table: "ExerciseStep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseRepFacade",
                table: "ExerciseRepFacade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseRep",
                table: "ExerciseRep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseFacade",
                table: "ExerciseFacade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exercise",
                table: "Exercise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicActionFacade",
                table: "BasicActionFacade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicAction",
                table: "BasicAction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEquiment",
                table: "BaseEquiment");

            migrationBuilder.RenameTable(
                name: "WorkoutDay",
                newName: "WorkoutDays");

            migrationBuilder.RenameTable(
                name: "ExerciseStepFacade",
                newName: "ExerciseStepFacades");

            migrationBuilder.RenameTable(
                name: "ExerciseStep",
                newName: "ExerciseSteps");

            migrationBuilder.RenameTable(
                name: "ExerciseRepFacade",
                newName: "ExerciseRepFacades");

            migrationBuilder.RenameTable(
                name: "ExerciseRep",
                newName: "ExerciseReps");

            migrationBuilder.RenameTable(
                name: "ExerciseFacade",
                newName: "ExerciseFacades");

            migrationBuilder.RenameTable(
                name: "Exercise",
                newName: "Exercises");

            migrationBuilder.RenameTable(
                name: "BasicActionFacade",
                newName: "BasicActionFacades");

            migrationBuilder.RenameTable(
                name: "BasicAction",
                newName: "BasicActions");

            migrationBuilder.RenameTable(
                name: "BaseEquiment",
                newName: "BaseEquipment");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseStepFacade_StepId",
                table: "ExerciseStepFacades",
                newName: "IX_ExerciseStepFacades_StepId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseStepFacade_ExerciseRepId",
                table: "ExerciseStepFacades",
                newName: "IX_ExerciseStepFacades_ExerciseRepId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseRepFacade_RepId",
                table: "ExerciseRepFacades",
                newName: "IX_ExerciseRepFacades_RepId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseRepFacade_ExerciseId",
                table: "ExerciseRepFacades",
                newName: "IX_ExerciseRepFacades_ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseFacade_WorkoutDayId",
                table: "ExerciseFacades",
                newName: "IX_ExerciseFacades_WorkoutDayId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseFacade_ExerciseId",
                table: "ExerciseFacades",
                newName: "IX_ExerciseFacades_ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicActionFacade_ExerciseStepId",
                table: "BasicActionFacades",
                newName: "IX_BasicActionFacades_ExerciseStepId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicActionFacade_BasicActionId",
                table: "BasicActionFacades",
                newName: "IX_BasicActionFacades_BasicActionId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicAction_EquipmentId",
                table: "BasicActions",
                newName: "IX_BasicActions_EquipmentId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "TimeComponent",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "EquipmentId",
                table: "BasicActions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutDays",
                table: "WorkoutDays",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseStepFacades",
                table: "ExerciseStepFacades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseSteps",
                table: "ExerciseSteps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseRepFacades",
                table: "ExerciseRepFacades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseReps",
                table: "ExerciseReps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseFacades",
                table: "ExerciseFacades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercises",
                table: "Exercises",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicActionFacades",
                table: "BasicActionFacades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicActions",
                table: "BasicActions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEquipment",
                table: "BaseEquipment",
                column: "Id");

            migrationBuilder.InsertData(
                table: "BaseEquipment",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("3a66ae5e-2837-4dcc-9e0b-ff320e444172"), "This is a treadmill", "Treadmill", 999.99000000000001 },
                    { new Guid("501a6eda-20cb-4742-8cab-23f1763c28e0"), "Plain white towel", "Towel", 4.0 }
                });

            migrationBuilder.InsertData(
                table: "BasicActions",
                columns: new[] { "Id", "Description", "EquipmentId", "Instruction", "Name" },
                values: new object[,]
                {
                    { new Guid("8f4db0a9-592e-42e2-a829-aa1796f8c51d"), "Put Towel To The Side", new Guid("501a6eda-20cb-4742-8cab-23f1763c28e0"), "If you are left handed, put the towel to your right side\n							   If you are right handed, put the towel to your left side", "Put Towel To The Side" },
                    { new Guid("e3d74580-7eef-4146-8d39-f988b7487b05"), "Treadmill running exercise", new Guid("3a66ae5e-2837-4dcc-9e0b-ff320e444172"), "Run on the treadmill at 8 km/h", "Treadmill running" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BasicActionFacades_BasicActions_BasicActionId",
                table: "BasicActionFacades",
                column: "BasicActionId",
                principalTable: "BasicActions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicActionFacades_ExerciseSteps_ExerciseStepId",
                table: "BasicActionFacades",
                column: "ExerciseStepId",
                principalTable: "ExerciseSteps",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicActions_BaseEquipment_EquipmentId",
                table: "BasicActions",
                column: "EquipmentId",
                principalTable: "BaseEquipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseFacades_Exercises_ExerciseId",
                table: "ExerciseFacades",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseFacades_WorkoutDays_WorkoutDayId",
                table: "ExerciseFacades",
                column: "WorkoutDayId",
                principalTable: "WorkoutDays",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseRepFacades_ExerciseReps_RepId",
                table: "ExerciseRepFacades",
                column: "RepId",
                principalTable: "ExerciseReps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseRepFacades_Exercises_ExerciseId",
                table: "ExerciseRepFacades",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseStepFacades_ExerciseReps_ExerciseRepId",
                table: "ExerciseStepFacades",
                column: "ExerciseRepId",
                principalTable: "ExerciseReps",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseStepFacades_ExerciseSteps_StepId",
                table: "ExerciseStepFacades",
                column: "StepId",
                principalTable: "ExerciseSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_BasicActionFacades_BasicActionFacadeId",
                table: "TimeComponent",
                column: "BasicActionFacadeId",
                principalTable: "BasicActionFacades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_ExerciseFacades_ExerciseFacadeId",
                table: "TimeComponent",
                column: "ExerciseFacadeId",
                principalTable: "ExerciseFacades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_ExerciseRepFacades_ExerciseRepFacadeId",
                table: "TimeComponent",
                column: "ExerciseRepFacadeId",
                principalTable: "ExerciseRepFacades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_ExerciseStepFacades_ExerciseStepFacadeId",
                table: "TimeComponent",
                column: "ExerciseStepFacadeId",
                principalTable: "ExerciseStepFacades",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicActionFacades_BasicActions_BasicActionId",
                table: "BasicActionFacades");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicActionFacades_ExerciseSteps_ExerciseStepId",
                table: "BasicActionFacades");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicActions_BaseEquipment_EquipmentId",
                table: "BasicActions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseFacades_Exercises_ExerciseId",
                table: "ExerciseFacades");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseFacades_WorkoutDays_WorkoutDayId",
                table: "ExerciseFacades");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseRepFacades_ExerciseReps_RepId",
                table: "ExerciseRepFacades");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseRepFacades_Exercises_ExerciseId",
                table: "ExerciseRepFacades");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseStepFacades_ExerciseReps_ExerciseRepId",
                table: "ExerciseStepFacades");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseStepFacades_ExerciseSteps_StepId",
                table: "ExerciseStepFacades");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_BasicActionFacades_BasicActionFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_ExerciseFacades_ExerciseFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_ExerciseRepFacades_ExerciseRepFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_ExerciseStepFacades_ExerciseStepFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutDays",
                table: "WorkoutDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseSteps",
                table: "ExerciseSteps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseStepFacades",
                table: "ExerciseStepFacades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exercises",
                table: "Exercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseReps",
                table: "ExerciseReps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseRepFacades",
                table: "ExerciseRepFacades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseFacades",
                table: "ExerciseFacades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicActions",
                table: "BasicActions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicActionFacades",
                table: "BasicActionFacades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEquipment",
                table: "BaseEquipment");

            migrationBuilder.DeleteData(
                table: "BasicActions",
                keyColumn: "Id",
                keyValue: new Guid("8f4db0a9-592e-42e2-a829-aa1796f8c51d"));

            migrationBuilder.DeleteData(
                table: "BasicActions",
                keyColumn: "Id",
                keyValue: new Guid("e3d74580-7eef-4146-8d39-f988b7487b05"));

            migrationBuilder.DeleteData(
                table: "BaseEquipment",
                keyColumn: "Id",
                keyValue: new Guid("3a66ae5e-2837-4dcc-9e0b-ff320e444172"));

            migrationBuilder.DeleteData(
                table: "BaseEquipment",
                keyColumn: "Id",
                keyValue: new Guid("501a6eda-20cb-4742-8cab-23f1763c28e0"));

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "TimeComponent");

            migrationBuilder.RenameTable(
                name: "WorkoutDays",
                newName: "WorkoutDay");

            migrationBuilder.RenameTable(
                name: "ExerciseSteps",
                newName: "ExerciseStep");

            migrationBuilder.RenameTable(
                name: "ExerciseStepFacades",
                newName: "ExerciseStepFacade");

            migrationBuilder.RenameTable(
                name: "Exercises",
                newName: "Exercise");

            migrationBuilder.RenameTable(
                name: "ExerciseReps",
                newName: "ExerciseRep");

            migrationBuilder.RenameTable(
                name: "ExerciseRepFacades",
                newName: "ExerciseRepFacade");

            migrationBuilder.RenameTable(
                name: "ExerciseFacades",
                newName: "ExerciseFacade");

            migrationBuilder.RenameTable(
                name: "BasicActions",
                newName: "BasicAction");

            migrationBuilder.RenameTable(
                name: "BasicActionFacades",
                newName: "BasicActionFacade");

            migrationBuilder.RenameTable(
                name: "BaseEquipment",
                newName: "BaseEquiment");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseStepFacades_StepId",
                table: "ExerciseStepFacade",
                newName: "IX_ExerciseStepFacade_StepId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseStepFacades_ExerciseRepId",
                table: "ExerciseStepFacade",
                newName: "IX_ExerciseStepFacade_ExerciseRepId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseRepFacades_RepId",
                table: "ExerciseRepFacade",
                newName: "IX_ExerciseRepFacade_RepId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseRepFacades_ExerciseId",
                table: "ExerciseRepFacade",
                newName: "IX_ExerciseRepFacade_ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseFacades_WorkoutDayId",
                table: "ExerciseFacade",
                newName: "IX_ExerciseFacade_WorkoutDayId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseFacades_ExerciseId",
                table: "ExerciseFacade",
                newName: "IX_ExerciseFacade_ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicActions_EquipmentId",
                table: "BasicAction",
                newName: "IX_BasicAction_EquipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicActionFacades_ExerciseStepId",
                table: "BasicActionFacade",
                newName: "IX_BasicActionFacade_ExerciseStepId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicActionFacades_BasicActionId",
                table: "BasicActionFacade",
                newName: "IX_BasicActionFacade_BasicActionId");

            migrationBuilder.AlterColumn<Guid>(
                name: "EquipmentId",
                table: "BasicAction",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutDay",
                table: "WorkoutDay",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseStep",
                table: "ExerciseStep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseStepFacade",
                table: "ExerciseStepFacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercise",
                table: "Exercise",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseRep",
                table: "ExerciseRep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseRepFacade",
                table: "ExerciseRepFacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseFacade",
                table: "ExerciseFacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicAction",
                table: "BasicAction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicActionFacade",
                table: "BasicActionFacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEquiment",
                table: "BaseEquiment",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BasicBreak",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicBreak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicBreak_TimeComponent_Id",
                        column: x => x.Id,
                        principalTable: "TimeComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BreakWithActions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakWithActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BreakWithActions_TimeComponent_Id",
                        column: x => x.Id,
                        principalTable: "TimeComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StartTime",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartTime_TimeComponent_Id",
                        column: x => x.Id,
                        principalTable: "TimeComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StopTime",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StopTime_TimeComponent_Id",
                        column: x => x.Id,
                        principalTable: "TimeComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BasicAction_BaseEquiment_EquipmentId",
                table: "BasicAction",
                column: "EquipmentId",
                principalTable: "BaseEquiment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicActionFacade_BasicAction_BasicActionId",
                table: "BasicActionFacade",
                column: "BasicActionId",
                principalTable: "BasicAction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicActionFacade_ExerciseStep_ExerciseStepId",
                table: "BasicActionFacade",
                column: "ExerciseStepId",
                principalTable: "ExerciseStep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseFacade_Exercise_ExerciseId",
                table: "ExerciseFacade",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseFacade_WorkoutDay_WorkoutDayId",
                table: "ExerciseFacade",
                column: "WorkoutDayId",
                principalTable: "WorkoutDay",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseRepFacade_ExerciseRep_RepId",
                table: "ExerciseRepFacade",
                column: "RepId",
                principalTable: "ExerciseRep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseRepFacade_Exercise_ExerciseId",
                table: "ExerciseRepFacade",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseStepFacade_ExerciseRep_ExerciseRepId",
                table: "ExerciseStepFacade",
                column: "ExerciseRepId",
                principalTable: "ExerciseRep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseStepFacade_ExerciseStep_StepId",
                table: "ExerciseStepFacade",
                column: "StepId",
                principalTable: "ExerciseStep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_BasicActionFacade_BasicActionFacadeId",
                table: "TimeComponent",
                column: "BasicActionFacadeId",
                principalTable: "BasicActionFacade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_ExerciseFacade_ExerciseFacadeId",
                table: "TimeComponent",
                column: "ExerciseFacadeId",
                principalTable: "ExerciseFacade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_ExerciseRepFacade_ExerciseRepFacadeId",
                table: "TimeComponent",
                column: "ExerciseRepFacadeId",
                principalTable: "ExerciseRepFacade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_ExerciseStepFacade_ExerciseStepFacadeId",
                table: "TimeComponent",
                column: "ExerciseStepFacadeId",
                principalTable: "ExerciseStepFacade",
                principalColumn: "Id");
        }
    }
}
