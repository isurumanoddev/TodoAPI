using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoAPI.Migrations
{
    public partial class changedayta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Street" },
                values: new object[] { "Q", "A" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Street" },
                values: new object[] { "H", "S" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Street" },
                values: new object[] { "W", "D" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Street" },
                values: new object[] { "T", "F" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Street" },
                values: new object[] { "E", "G" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Street" },
                values: new object[] { "C", "H" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Street" },
                values: new object[] { "VC", "K" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Street" },
                values: new object[] { "R", "H" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Street" },
                values: new object[] { "C", "Q" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 3, 24, 829, DateTimeKind.Local).AddTicks(9340), new DateTime(2022, 10, 2, 11, 3, 24, 830, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 3, 24, 830, DateTimeKind.Local).AddTicks(9910), new DateTime(2022, 10, 2, 11, 3, 24, 830, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 3, 24, 830, DateTimeKind.Local).AddTicks(9916), new DateTime(2022, 10, 2, 11, 3, 24, 830, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 3, 24, 830, DateTimeKind.Local).AddTicks(9919), new DateTime(2022, 10, 2, 11, 3, 24, 830, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 3, 24, 830, DateTimeKind.Local).AddTicks(9921), new DateTime(2022, 10, 2, 11, 3, 24, 830, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 3, 24, 830, DateTimeKind.Local).AddTicks(9923), new DateTime(2022, 10, 2, 11, 3, 24, 830, DateTimeKind.Local).AddTicks(9924) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Street" },
                values: new object[] { "rambukkana", "Kegalle" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Street" },
                values: new object[] { "rambukkana", "Kegalle" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Street" },
                values: new object[] { "rambukkana", "Kegalle" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Street" },
                values: new object[] { "rambukkana", "Kegalle" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Street" },
                values: new object[] { "rambukkana", "Kegalle" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Street" },
                values: new object[] { "rambukkana", "Kegalle" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Street" },
                values: new object[] { "rambukkana", "Kegalle" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Street" },
                values: new object[] { "rambukkana", "Kegalle" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Street" },
                values: new object[] { "rambukkana", "Kegalle" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 31, 4, 330, DateTimeKind.Local).AddTicks(7685), new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8366), new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8372), new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8374), new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8377), new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8379), new DateTime(2022, 10, 2, 10, 31, 4, 331, DateTimeKind.Local).AddTicks(8380) });
        }
    }
}
