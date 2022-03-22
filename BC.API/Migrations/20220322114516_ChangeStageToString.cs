using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BC.API.Migrations
{
    public partial class ChangeStageToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Stage",
                table: "Problems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "New",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.UpdateData(
                table: "DeliveryOrder",
                keyColumn: "Id",
                keyValue: new Guid("e0cd740a-7f17-4f2f-a627-91f930ad1e17"),
                column: "DateCreated",
                value: new DateTime(2022, 3, 22, 14, 45, 16, 171, DateTimeKind.Local).AddTicks(4319));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Stage",
                table: "Problems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "New");

            migrationBuilder.UpdateData(
                table: "DeliveryOrder",
                keyColumn: "Id",
                keyValue: new Guid("e0cd740a-7f17-4f2f-a627-91f930ad1e17"),
                column: "DateCreated",
                value: new DateTime(2022, 3, 22, 13, 30, 18, 816, DateTimeKind.Local).AddTicks(4086));
        }
    }
}
