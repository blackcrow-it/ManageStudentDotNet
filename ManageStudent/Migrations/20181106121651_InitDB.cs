using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageStudent.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "A00001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 6, 19, 16, 51, 375, DateTimeKind.Local), new DateTime(2018, 11, 6, 19, 16, 51, 380, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "A00002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 6, 19, 16, 51, 381, DateTimeKind.Local), new DateTime(2018, 11, 6, 19, 16, 51, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "A00003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 6, 19, 16, 51, 381, DateTimeKind.Local), new DateTime(2018, 11, 6, 19, 16, 51, 381, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "A00001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 6, 19, 15, 12, 473, DateTimeKind.Local), new DateTime(2018, 11, 6, 19, 15, 12, 478, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "A00002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 6, 19, 15, 12, 480, DateTimeKind.Local), new DateTime(2018, 11, 6, 19, 15, 12, 480, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "A00003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 6, 19, 15, 12, 480, DateTimeKind.Local), new DateTime(2018, 11, 6, 19, 15, 12, 480, DateTimeKind.Local) });
        }
    }
}
