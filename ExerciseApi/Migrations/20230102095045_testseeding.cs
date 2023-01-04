using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerciseApi.Migrations
{
    /// <inheritdoc />
    public partial class testseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseFacade_ExerciseFacade_RepId",
                table: "ExerciseFacade");

            migrationBuilder.DropColumn(
                name: "PerformConcurrently",
                table: "Exercise");

            migrationBuilder.RenameColumn(
                name: "RepId",
                table: "ExerciseFacade",
                newName: "ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseFacade_RepId",
                table: "ExerciseFacade",
                newName: "IX_ExerciseFacade_ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseFacade_Exercise_ExerciseId",
                table: "ExerciseFacade",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseFacade_Exercise_ExerciseId",
                table: "ExerciseFacade");

            migrationBuilder.RenameColumn(
                name: "ExerciseId",
                table: "ExerciseFacade",
                newName: "RepId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseFacade_ExerciseId",
                table: "ExerciseFacade",
                newName: "IX_ExerciseFacade_RepId");

            migrationBuilder.AddColumn<bool>(
                name: "PerformConcurrently",
                table: "Exercise",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseFacade_ExerciseFacade_RepId",
                table: "ExerciseFacade",
                column: "RepId",
                principalTable: "ExerciseFacade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
