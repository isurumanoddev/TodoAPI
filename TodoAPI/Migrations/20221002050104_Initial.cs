using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HomeNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Job = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Due = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Todos_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "City", "HomeNumber", "Job", "Name", "Street" },
                values: new object[,]
                {
                    { 1, "rambukkana", "1", "Devoloper", "isuru", "Kegalle" },
                    { 2, "rambukkana", "1", "Engineer", "Alex", "Kegalle" },
                    { 3, "rambukkana", "1", "Doctor", "Ann", "Kegalle" },
                    { 4, "rambukkana", "1", "Designer", "Max", "Kegalle" },
                    { 5, "rambukkana", "1", "Nurse", "tony", "Kegalle" },
                    { 6, "rambukkana", "1", "Teacher", "liee", "Kegalle" },
                    { 7, "rambukkana", "1", "Trader", "las", "Kegalle" },
                    { 8, "rambukkana", "1", "Investor", "Bee", "Kegalle" },
                    { 9, "rambukkana", "1", "Banker", "mac", "Kegalle" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Discription", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 2, 10, 31, 4, 330, DateTimeKind.Local).AddTicks(7685), "Drink 1 liter after workout", new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(7683), 2, "Drink water" },
                    { 2, 2, new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8366), "Drink 1 liter after workout", new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8370), 2, "DMake Tea" },
                    { 5, 2, new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8377), "Drink 1 liter after workout", new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8378), 2, "Breakfast" },
                    { 6, 2, new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8379), "Drink 1 liter after workout", new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8380), 2, "Breakfast" },
                    { 3, 3, new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8372), "Drink 1 liter after workout", new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8373), 2, "Toilet" },
                    { 4, 4, new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8374), "Drink 1 liter after workout", new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8375), 2, "Brush Teeth" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
