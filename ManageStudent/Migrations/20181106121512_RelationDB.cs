using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageStudent.Migrations
{
    public partial class RelationDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    RollNumber = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.RollNumber);
                });

            migrationBuilder.CreateTable(
                name: "Mark",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubjectName = table.Column<string>(nullable: true),
                    StudentRollNumber = table.Column<string>(nullable: true),
                    SubjectMark = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mark", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mark_Student_StudentRollNumber",
                        column: x => x.StudentRollNumber,
                        principalTable: "Student",
                        principalColumn: "RollNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreatedAt", "Email", "FirstName", "Gender", "LastName", "Status", "UpdatedAt" },
                values: new object[] { "A00001", new DateTime(2018, 11, 6, 19, 15, 12, 473, DateTimeKind.Local), "quanghungleo@gmail.com", "Hung", 1, "Nguyen", 1, new DateTime(2018, 11, 6, 19, 15, 12, 478, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreatedAt", "Email", "FirstName", "Gender", "LastName", "Status", "UpdatedAt" },
                values: new object[] { "A00002", new DateTime(2018, 11, 6, 19, 15, 12, 480, DateTimeKind.Local), "quanghungleo@gmail.com", "Hung", 1, "Nguyen", 1, new DateTime(2018, 11, 6, 19, 15, 12, 480, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreatedAt", "Email", "FirstName", "Gender", "LastName", "Status", "UpdatedAt" },
                values: new object[] { "A00003", new DateTime(2018, 11, 6, 19, 15, 12, 480, DateTimeKind.Local), "quanghungleo@gmail.com", "Hung", 1, "Nguyen", 1, new DateTime(2018, 11, 6, 19, 15, 12, 480, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "Id", "StudentRollNumber", "SubjectMark", "SubjectName" },
                values: new object[] { 1, "A00001", 24, "Java" });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "Id", "StudentRollNumber", "SubjectMark", "SubjectName" },
                values: new object[] { 2, "A00001", 23, "C#" });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "Id", "StudentRollNumber", "SubjectMark", "SubjectName" },
                values: new object[] { 3, "A00001", 27, "Python" });

            migrationBuilder.CreateIndex(
                name: "IX_Mark_StudentRollNumber",
                table: "Mark",
                column: "StudentRollNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mark");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
