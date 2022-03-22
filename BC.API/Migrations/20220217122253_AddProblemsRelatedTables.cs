using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BC.API.Migrations
{
    public partial class AddProblemsRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bicycles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bicycles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Problems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BicycleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFinished = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Problems_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Problems_Bicycles_BicycleId",
                        column: x => x.BicycleId,
                        principalTable: "Bicycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    AvailableQuantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: false),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartModels_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartModels_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartModelProblems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserChosenPartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProblemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    PricePerDetail = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartModelProblems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartModelProblems_PartModels_PartModelId",
                        column: x => x.PartModelId,
                        principalTable: "PartModels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartModelProblems_Parts_UserChosenPartId",
                        column: x => x.UserChosenPartId,
                        principalTable: "Parts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartModelProblems_Problems_ProblemId",
                        column: x => x.ProblemId,
                        principalTable: "Problems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartModelProblems_PartModelId",
                table: "PartModelProblems",
                column: "PartModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PartModelProblems_ProblemId_PartModelId",
                table: "PartModelProblems",
                columns: new[] { "ProblemId", "PartModelId" },
                unique: true,
                filter: "[PartModelId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PartModelProblems_UserChosenPartId",
                table: "PartModelProblems",
                column: "UserChosenPartId");

            migrationBuilder.CreateIndex(
                name: "IX_PartModels_ManufacturerId",
                table: "PartModels",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_PartModels_PartId",
                table: "PartModels",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_Problems_AddressId",
                table: "Problems",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Problems_BicycleId",
                table: "Problems",
                column: "BicycleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartModelProblems");

            migrationBuilder.DropTable(
                name: "PartModels");

            migrationBuilder.DropTable(
                name: "Problems");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Bicycles");
        }
    }
}
