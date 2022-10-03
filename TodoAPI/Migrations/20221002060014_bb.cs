using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoAPI.Migrations
{
    public partial class bb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Job",
                value: "Investor");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Job",
                value: "Devoloper");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Job",
                value: "Investor");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Job",
                value: "Devoloper");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Job",
                value: "Engineer");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(1720), new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(9639), new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(9646), new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(9649), new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(9651), new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(9654), new DateTime(2022, 10, 2, 11, 30, 13, 954, DateTimeKind.Local).AddTicks(9655) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Job",
                value: "Doctor");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Job",
                value: "Nurse");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Job",
                value: "Teacher");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Job",
                value: "Trader");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Job",
                value: "Banker");

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
    }
}
