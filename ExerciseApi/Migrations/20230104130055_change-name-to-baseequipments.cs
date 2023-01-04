using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerciseApi.Migrations
{
    /// <inheritdoc />
    public partial class changenametobaseequipments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicActions_BaseEquipment_EquipmentId",
                table: "BasicActions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEquipment",
                table: "BaseEquipment");

            migrationBuilder.RenameTable(
                name: "BaseEquipment",
                newName: "BaseEquipments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEquipments",
                table: "BaseEquipments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicActions_BaseEquipments_EquipmentId",
                table: "BasicActions",
                column: "EquipmentId",
                principalTable: "BaseEquipments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicActions_BaseEquipments_EquipmentId",
                table: "BasicActions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEquipments",
                table: "BaseEquipments");

            migrationBuilder.RenameTable(
                name: "BaseEquipments",
                newName: "BaseEquipment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEquipment",
                table: "BaseEquipment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicActions_BaseEquipment_EquipmentId",
                table: "BasicActions",
                column: "EquipmentId",
                principalTable: "BaseEquipment",
                principalColumn: "Id");
        }
    }
}
