using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Day02.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name", "MgrName" },
                values: new object[,]
                {
                       { 1, "Computer Science", "Dr. Smith" },
                       { 2, "Mathematics", "Dr. Johnson" },
                       { 3, "Physics", "Dr. Brown" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name", "Degree", "MinDegree", "DepartmentId" },
                values: new object[,]
                {
                       { 1, "Algorithms", "BSc", "C", 1 },
                       { 2, "Calculus", "BSc", "C", 2 },
                       { 3, "Quantum Mechanics", "BSc", "C", 3 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Age", "DepartmentId" },
                values: new object[,]
                {
                       { 1, "Alice", 20, 1 },
                       { 2, "Bob", 22, 2 },
                       { 3, "Charlie", 21, 3 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "Salary", "Address", "CourseId", "DepartmentId" },
                values: new object[,]
                {
                       { 1, "Prof. Brown", 80000, "123 Main St", 1, 1 },
                       { 2, "Prof. Green", 75000, "456 Elm St", 2, 2 },
                       { 3, "Prof. White", 78000, "789 Oak St", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "StuCrsRes",
                columns: new[] { "StudentId", "CourseId", "Grade" },
                values: new object[,]
                {
                       { 1, 1, 85 },
                       { 2, 2, 90 },
                       { 3, 3, 88 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StuCrsRes",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StuCrsRes",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StuCrsRes",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
