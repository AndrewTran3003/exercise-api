using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerciseApi.Migrations
{
    /// <inheritdoc />
    public partial class RefactorModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_exercise_ExerciseComponent_Id",
                table: "exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_exerciserep_break_BreakId",
                table: "exerciserep");

            migrationBuilder.DropForeignKey(
                name: "FK_exerciserep_exercise_ExerciseId",
                table: "exerciserep");

            migrationBuilder.DropForeignKey(
                name: "FK_exercisestep_exerciserep_ExerciseRepId",
                table: "exercisestep");

            migrationBuilder.DropTable(
                name: "break");

            migrationBuilder.DropTable(
                name: "equipment");

            migrationBuilder.DropTable(
                name: "ExerciseComponent");

            migrationBuilder.DropIndex(
                name: "IX_exercisestep_ExerciseRepId",
                table: "exercisestep");

            migrationBuilder.DropIndex(
                name: "IX_exerciserep_BreakId",
                table: "exerciserep");

            migrationBuilder.DropIndex(
                name: "IX_exerciserep_ExerciseId",
                table: "exerciserep");

            migrationBuilder.DropColumn(
                name: "ExerciseRepId",
                table: "exercisestep");

            migrationBuilder.DropColumn(
                name: "BreakId",
                table: "exerciserep");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "exerciserep");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "exercise");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "workoutday",
                newName: "DateTaken");

            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "exercisestep",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "exercisestep",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PerformConcurrently",
                table: "exercisestep",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "exerciserep",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "exerciserep",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PerformConcurrently",
                table: "exerciserep",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "exercise",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "exercise",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PerformConcurrently",
                table: "exercise",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "baseequiment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_baseequiment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "exercisefacade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RepId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkoutDayId = table.Column<Guid>(type: "uuid", nullable: true),
                    Completed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercisefacade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_exercisefacade_exercisefacade_RepId",
                        column: x => x.RepId,
                        principalTable: "exercisefacade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_exercisefacade_workoutday_WorkoutDayId",
                        column: x => x.WorkoutDayId,
                        principalTable: "workoutday",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "exerciserepfacade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RepId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: true),
                    Completed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exerciserepfacade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_exerciserepfacade_exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "exercise",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_exerciserepfacade_exerciserep_RepId",
                        column: x => x.RepId,
                        principalTable: "exerciserep",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "exercisestepfacade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StepId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExerciseRepId = table.Column<Guid>(type: "uuid", nullable: true),
                    Completed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercisestepfacade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_exercisestepfacade_exerciserep_ExerciseRepId",
                        column: x => x.ExerciseRepId,
                        principalTable: "exerciserep",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_exercisestepfacade_exercisestep_StepId",
                        column: x => x.StepId,
                        principalTable: "exercisestep",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "basicaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Instruction = table.Column<string>(type: "text", nullable: true),
                    EquipmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_basicaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_basicaction_baseequiment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "baseequiment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "basicactionfacade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BasicActionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExerciseStepId = table.Column<Guid>(type: "uuid", nullable: true),
                    Completed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_basicactionfacade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_basicactionfacade_basicaction_BasicActionId",
                        column: x => x.BasicActionId,
                        principalTable: "basicaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_basicactionfacade_exercisestep_ExerciseStepId",
                        column: x => x.ExerciseStepId,
                        principalTable: "exercisestep",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TimeComponent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "interval", nullable: false),
                    BasicActionFacadeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ExerciseFacadeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ExerciseRepFacadeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ExerciseStepFacadeId = table.Column<Guid>(type: "uuid", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeComponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeComponent_basicactionfacade_BasicActionFacadeId",
                        column: x => x.BasicActionFacadeId,
                        principalTable: "basicactionfacade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeComponent_exercisefacade_ExerciseFacadeId",
                        column: x => x.ExerciseFacadeId,
                        principalTable: "exercisefacade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeComponent_exerciserepfacade_ExerciseRepFacadeId",
                        column: x => x.ExerciseRepFacadeId,
                        principalTable: "exerciserepfacade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeComponent_exercisestepfacade_ExerciseStepFacadeId",
                        column: x => x.ExerciseStepFacadeId,
                        principalTable: "exercisestepfacade",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "basicbreak",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_basicbreak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_basicbreak_TimeComponent_Id",
                        column: x => x.Id,
                        principalTable: "TimeComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "breakwithactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_breakwithactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_breakwithactions_TimeComponent_Id",
                        column: x => x.Id,
                        principalTable: "TimeComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "starttime",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_starttime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_starttime_TimeComponent_Id",
                        column: x => x.Id,
                        principalTable: "TimeComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stoptime",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stoptime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stoptime_TimeComponent_Id",
                        column: x => x.Id,
                        principalTable: "TimeComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_basicaction_EquipmentId",
                table: "basicaction",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_basicactionfacade_BasicActionId",
                table: "basicactionfacade",
                column: "BasicActionId");

            migrationBuilder.CreateIndex(
                name: "IX_basicactionfacade_ExerciseStepId",
                table: "basicactionfacade",
                column: "ExerciseStepId");

            migrationBuilder.CreateIndex(
                name: "IX_exercisefacade_RepId",
                table: "exercisefacade",
                column: "RepId");

            migrationBuilder.CreateIndex(
                name: "IX_exercisefacade_WorkoutDayId",
                table: "exercisefacade",
                column: "WorkoutDayId");

            migrationBuilder.CreateIndex(
                name: "IX_exerciserepfacade_ExerciseId",
                table: "exerciserepfacade",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_exerciserepfacade_RepId",
                table: "exerciserepfacade",
                column: "RepId");

            migrationBuilder.CreateIndex(
                name: "IX_exercisestepfacade_ExerciseRepId",
                table: "exercisestepfacade",
                column: "ExerciseRepId");

            migrationBuilder.CreateIndex(
                name: "IX_exercisestepfacade_StepId",
                table: "exercisestepfacade",
                column: "StepId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeComponent_BasicActionFacadeId",
                table: "TimeComponent",
                column: "BasicActionFacadeId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeComponent_ExerciseFacadeId",
                table: "TimeComponent",
                column: "ExerciseFacadeId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeComponent_ExerciseRepFacadeId",
                table: "TimeComponent",
                column: "ExerciseRepFacadeId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeComponent_ExerciseStepFacadeId",
                table: "TimeComponent",
                column: "ExerciseStepFacadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "basicbreak");

            migrationBuilder.DropTable(
                name: "breakwithactions");

            migrationBuilder.DropTable(
                name: "starttime");

            migrationBuilder.DropTable(
                name: "stoptime");

            migrationBuilder.DropTable(
                name: "TimeComponent");

            migrationBuilder.DropTable(
                name: "basicactionfacade");

            migrationBuilder.DropTable(
                name: "exercisefacade");

            migrationBuilder.DropTable(
                name: "exerciserepfacade");

            migrationBuilder.DropTable(
                name: "exercisestepfacade");

            migrationBuilder.DropTable(
                name: "basicaction");

            migrationBuilder.DropTable(
                name: "baseequiment");

            migrationBuilder.DropColumn(
                name: "Completed",
                table: "exercisestep");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "exercisestep");

            migrationBuilder.DropColumn(
                name: "PerformConcurrently",
                table: "exercisestep");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "exerciserep");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "exerciserep");

            migrationBuilder.DropColumn(
                name: "PerformConcurrently",
                table: "exerciserep");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "exercise");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "exercise");

            migrationBuilder.DropColumn(
                name: "PerformConcurrently",
                table: "exercise");

            migrationBuilder.RenameColumn(
                name: "DateTaken",
                table: "workoutday",
                newName: "Date");

            migrationBuilder.AddColumn<Guid>(
                name: "ExerciseRepId",
                table: "exercisestep",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BreakId",
                table: "exerciserep",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExerciseId",
                table: "exerciserep",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Duration",
                table: "exercise",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "equipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: true),
                    ExerciseStepId = table.Column<Guid>(type: "uuid", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_equipment_exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "exercise",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_equipment_exercisestep_ExerciseStepId",
                        column: x => x.ExerciseStepId,
                        principalTable: "exercisestep",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExerciseComponent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    WorkoutDayId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseComponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseComponent_workoutday_WorkoutDayId",
                        column: x => x.WorkoutDayId,
                        principalTable: "workoutday",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "break",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Duration = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_break", x => x.Id);
                    table.ForeignKey(
                        name: "FK_break_ExerciseComponent_Id",
                        column: x => x.Id,
                        principalTable: "ExerciseComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_exercisestep_ExerciseRepId",
                table: "exercisestep",
                column: "ExerciseRepId");

            migrationBuilder.CreateIndex(
                name: "IX_exerciserep_BreakId",
                table: "exerciserep",
                column: "BreakId");

            migrationBuilder.CreateIndex(
                name: "IX_exerciserep_ExerciseId",
                table: "exerciserep",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_equipment_ExerciseId",
                table: "equipment",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_equipment_ExerciseStepId",
                table: "equipment",
                column: "ExerciseStepId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseComponent_WorkoutDayId",
                table: "ExerciseComponent",
                column: "WorkoutDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_exercise_ExerciseComponent_Id",
                table: "exercise",
                column: "Id",
                principalTable: "ExerciseComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exerciserep_break_BreakId",
                table: "exerciserep",
                column: "BreakId",
                principalTable: "break",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_exerciserep_exercise_ExerciseId",
                table: "exerciserep",
                column: "ExerciseId",
                principalTable: "exercise",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_exercisestep_exerciserep_ExerciseRepId",
                table: "exercisestep",
                column: "ExerciseRepId",
                principalTable: "exerciserep",
                principalColumn: "Id");
        }
    }
}
