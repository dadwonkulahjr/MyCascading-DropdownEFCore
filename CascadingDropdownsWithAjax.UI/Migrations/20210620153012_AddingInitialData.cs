using Microsoft.EntityFrameworkCore.Migrations;

namespace CascadingDropdownsWithAjax.UI.Migrations
{
    public partial class AddingInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseName", "CreditHours", "StudentId" },
                values: new object[,]
                {
                    { 1, "Razor Pages", 4, 1 },
                    { 2, "Database Fundamentals", 5, 1 },
                    { 3, "Software Development Fundamentals", 4, 2 },
                    { 4, "MVC", 8, 3 },
                    { 5, "EFCore", 5, 2 },
                    { 6, "Web Development", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "mike@m.com", "Mike", "Smith" },
                    { 2, "tom@m.com", "Tom", "Hasting" },
                    { 3, "mike@m.com", "Mike", "Smith" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 3);
        }
    }
}
