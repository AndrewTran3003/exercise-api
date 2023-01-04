using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExerciseApi.Migrations
{
    /// <inheritdoc />
    public partial class testseeding3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicActions_BaseEquipment_EquipmentId",
                table: "BasicActions");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "EquipmentId",
                table: "BasicActions",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicActions_BaseEquipment_EquipmentId",
                table: "BasicActions",
                column: "EquipmentId",
                principalTable: "BaseEquipment",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicActions_BaseEquipment_EquipmentId",
                table: "BasicActions");

            migrationBuilder.AlterColumn<Guid>(
                name: "EquipmentId",
                table: "BasicActions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

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
                name: "FK_BasicActions_BaseEquipment_EquipmentId",
                table: "BasicActions",
                column: "EquipmentId",
                principalTable: "BaseEquipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
