using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerciseApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_basicaction_baseequiment_EquipmentId",
                table: "basicaction");

            migrationBuilder.DropForeignKey(
                name: "FK_basicactionfacade_basicaction_BasicActionId",
                table: "basicactionfacade");

            migrationBuilder.DropForeignKey(
                name: "FK_basicactionfacade_exercisestep_ExerciseStepId",
                table: "basicactionfacade");

            migrationBuilder.DropForeignKey(
                name: "FK_basicbreak_TimeComponent_Id",
                table: "basicbreak");

            migrationBuilder.DropForeignKey(
                name: "FK_breakwithactions_TimeComponent_Id",
                table: "breakwithactions");

            migrationBuilder.DropForeignKey(
                name: "FK_exercisefacade_exercisefacade_RepId",
                table: "exercisefacade");

            migrationBuilder.DropForeignKey(
                name: "FK_exercisefacade_workoutday_WorkoutDayId",
                table: "exercisefacade");

            migrationBuilder.DropForeignKey(
                name: "FK_exerciserepfacade_exercise_ExerciseId",
                table: "exerciserepfacade");

            migrationBuilder.DropForeignKey(
                name: "FK_exerciserepfacade_exerciserep_RepId",
                table: "exerciserepfacade");

            migrationBuilder.DropForeignKey(
                name: "FK_exercisestepfacade_exerciserep_ExerciseRepId",
                table: "exercisestepfacade");

            migrationBuilder.DropForeignKey(
                name: "FK_exercisestepfacade_exercisestep_StepId",
                table: "exercisestepfacade");

            migrationBuilder.DropForeignKey(
                name: "FK_starttime_TimeComponent_Id",
                table: "starttime");

            migrationBuilder.DropForeignKey(
                name: "FK_stoptime_TimeComponent_Id",
                table: "stoptime");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_basicactionfacade_BasicActionFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_exercisefacade_ExerciseFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_exerciserepfacade_ExerciseRepFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeComponent_exercisestepfacade_ExerciseStepFacadeId",
                table: "TimeComponent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_workoutday",
                table: "workoutday");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stoptime",
                table: "stoptime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_starttime",
                table: "starttime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_exercisestepfacade",
                table: "exercisestepfacade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_exercisestep",
                table: "exercisestep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_exerciserepfacade",
                table: "exerciserepfacade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_exerciserep",
                table: "exerciserep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_exercisefacade",
                table: "exercisefacade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_exercise",
                table: "exercise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_breakwithactions",
                table: "breakwithactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_basicbreak",
                table: "basicbreak");

            migrationBuilder.DropPrimaryKey(
                name: "PK_basicactionfacade",
                table: "basicactionfacade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_basicaction",
                table: "basicaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_baseequiment",
                table: "baseequiment");

            migrationBuilder.RenameTable(
                name: "workoutday",
                newName: "WorkoutDay");

            migrationBuilder.RenameTable(
                name: "stoptime",
                newName: "StopTime");

            migrationBuilder.RenameTable(
                name: "starttime",
                newName: "StartTime");

            migrationBuilder.RenameTable(
                name: "exercisestepfacade",
                newName: "ExerciseStepFacade");

            migrationBuilder.RenameTable(
                name: "exercisestep",
                newName: "ExerciseStep");

            migrationBuilder.RenameTable(
                name: "exerciserepfacade",
                newName: "ExerciseRepFacade");

            migrationBuilder.RenameTable(
                name: "exerciserep",
                newName: "ExerciseRep");

            migrationBuilder.RenameTable(
                name: "exercisefacade",
                newName: "ExerciseFacade");

            migrationBuilder.RenameTable(
                name: "exercise",
                newName: "Exercise");

            migrationBuilder.RenameTable(
                name: "breakwithactions",
                newName: "BreakWithActions");

            migrationBuilder.RenameTable(
                name: "basicbreak",
                newName: "BasicBreak");

            migrationBuilder.RenameTable(
                name: "basicactionfacade",
                newName: "BasicActionFacade");

            migrationBuilder.RenameTable(
                name: "basicaction",
                newName: "BasicAction");

            migrationBuilder.RenameTable(
                name: "baseequiment",
                newName: "BaseEquiment");

            migrationBuilder.RenameIndex(
                name: "IX_exercisestepfacade_StepId",
                table: "ExerciseStepFacade",
                newName: "IX_ExerciseStepFacade_StepId");

            migrationBuilder.RenameIndex(
                name: "IX_exercisestepfacade_ExerciseRepId",
                table: "ExerciseStepFacade",
                newName: "IX_ExerciseStepFacade_ExerciseRepId");

            migrationBuilder.RenameIndex(
                name: "IX_exerciserepfacade_RepId",
                table: "ExerciseRepFacade",
                newName: "IX_ExerciseRepFacade_RepId");

            migrationBuilder.RenameIndex(
                name: "IX_exerciserepfacade_ExerciseId",
                table: "ExerciseRepFacade",
                newName: "IX_ExerciseRepFacade_ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_exercisefacade_WorkoutDayId",
                table: "ExerciseFacade",
                newName: "IX_ExerciseFacade_WorkoutDayId");

            migrationBuilder.RenameIndex(
                name: "IX_exercisefacade_RepId",
                table: "ExerciseFacade",
                newName: "IX_ExerciseFacade_RepId");

            migrationBuilder.RenameIndex(
                name: "IX_basicactionfacade_ExerciseStepId",
                table: "BasicActionFacade",
                newName: "IX_BasicActionFacade_ExerciseStepId");

            migrationBuilder.RenameIndex(
                name: "IX_basicactionfacade_BasicActionId",
                table: "BasicActionFacade",
                newName: "IX_BasicActionFacade_BasicActionId");

            migrationBuilder.RenameIndex(
                name: "IX_basicaction_EquipmentId",
                table: "BasicAction",
                newName: "IX_BasicAction_EquipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutDay",
                table: "WorkoutDay",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StopTime",
                table: "StopTime",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StartTime",
                table: "StartTime",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseStepFacade",
                table: "ExerciseStepFacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseStep",
                table: "ExerciseStep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseRepFacade",
                table: "ExerciseRepFacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseRep",
                table: "ExerciseRep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseFacade",
                table: "ExerciseFacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercise",
                table: "Exercise",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BreakWithActions",
                table: "BreakWithActions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicBreak",
                table: "BasicBreak",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicActionFacade",
                table: "BasicActionFacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicAction",
                table: "BasicAction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEquiment",
                table: "BaseEquiment",
                column: "Id");

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
                name: "FK_BasicBreak_TimeComponent_Id",
                table: "BasicBreak",
                column: "Id",
                principalTable: "TimeComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BreakWithActions_TimeComponent_Id",
                table: "BreakWithActions",
                column: "Id",
                principalTable: "TimeComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseFacade_ExerciseFacade_RepId",
                table: "ExerciseFacade",
                column: "RepId",
                principalTable: "ExerciseFacade",
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
                name: "FK_StartTime_TimeComponent_Id",
                table: "StartTime",
                column: "Id",
                principalTable: "TimeComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StopTime_TimeComponent_Id",
                table: "StopTime",
                column: "Id",
                principalTable: "TimeComponent",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_BasicBreak_TimeComponent_Id",
                table: "BasicBreak");

            migrationBuilder.DropForeignKey(
                name: "FK_BreakWithActions_TimeComponent_Id",
                table: "BreakWithActions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseFacade_ExerciseFacade_RepId",
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
                name: "FK_StartTime_TimeComponent_Id",
                table: "StartTime");

            migrationBuilder.DropForeignKey(
                name: "FK_StopTime_TimeComponent_Id",
                table: "StopTime");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutDay",
                table: "WorkoutDay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StopTime",
                table: "StopTime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StartTime",
                table: "StartTime");

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
                name: "PK_BreakWithActions",
                table: "BreakWithActions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicBreak",
                table: "BasicBreak");

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
                newName: "workoutday");

            migrationBuilder.RenameTable(
                name: "StopTime",
                newName: "stoptime");

            migrationBuilder.RenameTable(
                name: "StartTime",
                newName: "starttime");

            migrationBuilder.RenameTable(
                name: "ExerciseStepFacade",
                newName: "exercisestepfacade");

            migrationBuilder.RenameTable(
                name: "ExerciseStep",
                newName: "exercisestep");

            migrationBuilder.RenameTable(
                name: "ExerciseRepFacade",
                newName: "exerciserepfacade");

            migrationBuilder.RenameTable(
                name: "ExerciseRep",
                newName: "exerciserep");

            migrationBuilder.RenameTable(
                name: "ExerciseFacade",
                newName: "exercisefacade");

            migrationBuilder.RenameTable(
                name: "Exercise",
                newName: "exercise");

            migrationBuilder.RenameTable(
                name: "BreakWithActions",
                newName: "breakwithactions");

            migrationBuilder.RenameTable(
                name: "BasicBreak",
                newName: "basicbreak");

            migrationBuilder.RenameTable(
                name: "BasicActionFacade",
                newName: "basicactionfacade");

            migrationBuilder.RenameTable(
                name: "BasicAction",
                newName: "basicaction");

            migrationBuilder.RenameTable(
                name: "BaseEquiment",
                newName: "baseequiment");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseStepFacade_StepId",
                table: "exercisestepfacade",
                newName: "IX_exercisestepfacade_StepId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseStepFacade_ExerciseRepId",
                table: "exercisestepfacade",
                newName: "IX_exercisestepfacade_ExerciseRepId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseRepFacade_RepId",
                table: "exerciserepfacade",
                newName: "IX_exerciserepfacade_RepId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseRepFacade_ExerciseId",
                table: "exerciserepfacade",
                newName: "IX_exerciserepfacade_ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseFacade_WorkoutDayId",
                table: "exercisefacade",
                newName: "IX_exercisefacade_WorkoutDayId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseFacade_RepId",
                table: "exercisefacade",
                newName: "IX_exercisefacade_RepId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicActionFacade_ExerciseStepId",
                table: "basicactionfacade",
                newName: "IX_basicactionfacade_ExerciseStepId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicActionFacade_BasicActionId",
                table: "basicactionfacade",
                newName: "IX_basicactionfacade_BasicActionId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicAction_EquipmentId",
                table: "basicaction",
                newName: "IX_basicaction_EquipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_workoutday",
                table: "workoutday",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stoptime",
                table: "stoptime",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_starttime",
                table: "starttime",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_exercisestepfacade",
                table: "exercisestepfacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_exercisestep",
                table: "exercisestep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_exerciserepfacade",
                table: "exerciserepfacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_exerciserep",
                table: "exerciserep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_exercisefacade",
                table: "exercisefacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_exercise",
                table: "exercise",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_breakwithactions",
                table: "breakwithactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_basicbreak",
                table: "basicbreak",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_basicactionfacade",
                table: "basicactionfacade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_basicaction",
                table: "basicaction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_baseequiment",
                table: "baseequiment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_basicaction_baseequiment_EquipmentId",
                table: "basicaction",
                column: "EquipmentId",
                principalTable: "baseequiment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_basicactionfacade_basicaction_BasicActionId",
                table: "basicactionfacade",
                column: "BasicActionId",
                principalTable: "basicaction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_basicactionfacade_exercisestep_ExerciseStepId",
                table: "basicactionfacade",
                column: "ExerciseStepId",
                principalTable: "exercisestep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_basicbreak_TimeComponent_Id",
                table: "basicbreak",
                column: "Id",
                principalTable: "TimeComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_breakwithactions_TimeComponent_Id",
                table: "breakwithactions",
                column: "Id",
                principalTable: "TimeComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exercisefacade_exercisefacade_RepId",
                table: "exercisefacade",
                column: "RepId",
                principalTable: "exercisefacade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exercisefacade_workoutday_WorkoutDayId",
                table: "exercisefacade",
                column: "WorkoutDayId",
                principalTable: "workoutday",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_exerciserepfacade_exercise_ExerciseId",
                table: "exerciserepfacade",
                column: "ExerciseId",
                principalTable: "exercise",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_exerciserepfacade_exerciserep_RepId",
                table: "exerciserepfacade",
                column: "RepId",
                principalTable: "exerciserep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exercisestepfacade_exerciserep_ExerciseRepId",
                table: "exercisestepfacade",
                column: "ExerciseRepId",
                principalTable: "exerciserep",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_exercisestepfacade_exercisestep_StepId",
                table: "exercisestepfacade",
                column: "StepId",
                principalTable: "exercisestep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_starttime_TimeComponent_Id",
                table: "starttime",
                column: "Id",
                principalTable: "TimeComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stoptime_TimeComponent_Id",
                table: "stoptime",
                column: "Id",
                principalTable: "TimeComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_basicactionfacade_BasicActionFacadeId",
                table: "TimeComponent",
                column: "BasicActionFacadeId",
                principalTable: "basicactionfacade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_exercisefacade_ExerciseFacadeId",
                table: "TimeComponent",
                column: "ExerciseFacadeId",
                principalTable: "exercisefacade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_exerciserepfacade_ExerciseRepFacadeId",
                table: "TimeComponent",
                column: "ExerciseRepFacadeId",
                principalTable: "exerciserepfacade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeComponent_exercisestepfacade_ExerciseStepFacadeId",
                table: "TimeComponent",
                column: "ExerciseStepFacadeId",
                principalTable: "exercisestepfacade",
                principalColumn: "Id");
        }
    }
}
