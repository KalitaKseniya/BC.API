using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BC.API.Migrations
{
    public partial class deliverySeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Provider",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { new Guid("2c05de27-bb62-4149-a55f-728a9dacb701"), "provider1@providers.com", "Provider Providerovich", "298162363" });

            migrationBuilder.InsertData(
                table: "DeliveryOrder",
                columns: new[] { "Id", "DateCreated", "DateFinished", "ProviderId", "Stage" },
                values: new object[] { new Guid("e0cd740a-7f17-4f2f-a627-91f930ad1e17"), new DateTime(2022, 3, 22, 13, 30, 18, 816, DateTimeKind.Local).AddTicks(4086), null, new Guid("2c05de27-bb62-4149-a55f-728a9dacb701"), "New" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeliveryOrder",
                keyColumn: "Id",
                keyValue: new Guid("e0cd740a-7f17-4f2f-a627-91f930ad1e17"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: new Guid("2c05de27-bb62-4149-a55f-728a9dacb701"));
        }
    }
}
