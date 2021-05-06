using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExportHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExportDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PlaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExportHistory_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Place1" },
                    { 2, "Place2" },
                    { 3, "Place3" },
                    { 4, "Place4" },
                    { 5, "Place5" },
                    { 6, "Place6" }
                });

            migrationBuilder.InsertData(
                table: "ExportHistory",
                columns: new[] { "Id", "ExportDateTime", "Name", "PlaceId", "User" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 5, 16, 12, 25, 755, DateTimeKind.Local).AddTicks(8295), "Test1", 1, "User1" },
                    { 4, new DateTime(2021, 5, 2, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5910), "Test4", 4, "User1" },
                    { 18, new DateTime(2021, 5, 1, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5982), "Test17", 3, "User6" },
                    { 17, new DateTime(2021, 5, 1, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5978), "Test17", 3, "User5" },
                    { 16, new DateTime(2021, 5, 1, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5973), "Test16", 3, "User4" },
                    { 15, new DateTime(2021, 5, 11, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5969), "Test15", 3, "User4" },
                    { 14, new DateTime(2021, 5, 11, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5962), "Test14", 3, "User4" },
                    { 3, new DateTime(2021, 5, 3, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5903), "Test3", 3, "User1" },
                    { 13, new DateTime(2021, 5, 11, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5959), "Test13", 2, "User3" },
                    { 12, new DateTime(2021, 5, 11, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5954), "Test12", 2, "User3" },
                    { 11, new DateTime(2021, 5, 10, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5950), "Test11", 2, "User3" },
                    { 10, new DateTime(2021, 5, 9, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5947), "Test10", 2, "User3" },
                    { 2, new DateTime(2021, 5, 4, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5861), "Test2", 2, "User1" },
                    { 9, new DateTime(2021, 5, 8, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5943), "Test9", 1, "User2" },
                    { 8, new DateTime(2021, 5, 7, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5936), "Test8", 1, "User2" },
                    { 7, new DateTime(2021, 5, 11, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5922), "Test7", 1, "User2" },
                    { 5, new DateTime(2021, 5, 1, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5914), "Test5", 4, "User2" },
                    { 6, new DateTime(2021, 5, 1, 16, 12, 25, 759, DateTimeKind.Local).AddTicks(5918), "Test6", 5, "User2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExportHistory_PlaceId",
                table: "ExportHistory",
                column: "PlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExportHistory");

            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
