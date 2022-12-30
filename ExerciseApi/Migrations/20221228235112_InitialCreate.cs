using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerciseApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "workoutday",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Completed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workoutday", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseComponent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "exercise",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Duration = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Completed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_exercise_ExerciseComponent_Id",
                        column: x => x.Id,
                        principalTable: "ExerciseComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "exerciserep",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Completed = table.Column<bool>(type: "boolean", nullable: false),
                    BreakId = table.Column<Guid>(type: "uuid", nullable: true),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exerciserep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_exerciserep_break_BreakId",
                        column: x => x.BreakId,
                        principalTable: "break",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_exerciserep_exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "exercise",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "exercisestep",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ExerciseRepId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercisestep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_exercisestep_exerciserep_ExerciseRepId",
                        column: x => x.ExerciseRepId,
                        principalTable: "exerciserep",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "equipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: true),
                    ExerciseStepId = table.Column<Guid>(type: "uuid", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_exerciserep_BreakId",
                table: "exerciserep",
                column: "BreakId");

            migrationBuilder.CreateIndex(
                name: "IX_exerciserep_ExerciseId",
                table: "exerciserep",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_exercisestep_ExerciseRepId",
                table: "exercisestep",
                column: "ExerciseRepId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "equipment");

            migrationBuilder.DropTable(
                name: "exercisestep");

            migrationBuilder.DropTable(
                name: "exerciserep");

            migrationBuilder.DropTable(
                name: "break");

            migrationBuilder.DropTable(
                name: "exercise");

            migrationBuilder.DropTable(
                name: "ExerciseComponent");

            migrationBuilder.DropTable(
                name: "workoutday");
        }
    }
}
