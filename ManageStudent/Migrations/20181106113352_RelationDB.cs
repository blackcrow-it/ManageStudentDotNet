using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageStudent.Migrations
{
    internal partial class RelationDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mark",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubjectName = table.Column<string>(nullable: true),
                    SubjectRollNumber = table.Column<string>(nullable: true),
                    SubjectMark = table.Column<int>(nullable: false),
                    StudentRollNumber = table.Column<string>(nullable: true)
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
                table: "Mark",
                columns: new[] { "Id", "StudentRollNumber", "SubjectMark", "SubjectName", "SubjectRollNumber" },
                values: new object[,]
                {
                    { 1, null, 24, "Java", "A00001" },
                    { 2, null, 23, "C#", "A00001" },
                    { 3, null, 27, "Python", "A00001" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreatedAt", "Email", "FirstName", "Gender", "LastName", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { "A00001", new DateTime(2018, 11, 6, 18, 33, 52, 501, DateTimeKind.Local), "quanghungleo@gmail.com", "Hung", 1, "Nguyen", 1, new DateTime(2018, 11, 6, 18, 33, 52, 503, DateTimeKind.Local) },
                    { "A00002", new DateTime(2018, 11, 6, 18, 33, 52, 504, DateTimeKind.Local), "quanghungleo@gmail.com", "Hung", 1, "Nguyen", 1, new DateTime(2018, 11, 6, 18, 33, 52, 504, DateTimeKind.Local) },
                    { "A00003", new DateTime(2018, 11, 6, 18, 33, 52, 504, DateTimeKind.Local), "quanghungleo@gmail.com", "Hung", 1, "Nguyen", 1, new DateTime(2018, 11, 6, 18, 33, 52, 504, DateTimeKind.Local) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mark_StudentRollNumber",
                table: "Mark",
                column: "StudentRollNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mark");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "A00001");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "A00002");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "A00003");
        }
    }
}
