using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Employees.Migrations
{
    /// <inheritdoc />
    public partial class seedemployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeePositions",
                columns: new[] { "Id", "DateOfJoining", "EmpPosition", "Salary" },
                values: new object[,]
                {
                    { new Guid("16975232-3c77-4d04-b6a4-e487c7543a1b"), new DateTime(2023, 3, 1, 4, 0, 0, 0, DateTimeKind.Utc), "Consultant", 5000000m },
                    { new Guid("8c6e2da6-ce23-4b6f-b980-348fb630c3eb"), new DateTime(2022, 2, 1, 4, 0, 0, 0, DateTimeKind.Utc), "Manager", 5m }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmpId", "Address", "DOB", "Department", "EmpFname", "EmpLname", "Gender", "ProjectId" },
                values: new object[,]
                {
                    { new Guid("16975232-3c77-4d04-b6a4-e487c7543a1b"), "999 street", new DateTime(2000, 1, 1, 4, 0, 0, 0, DateTimeKind.Utc), "dept2", "Bob", "Smith", "Female", new Guid("26c6f55c-ad3b-4a4d-9e44-1b60fc755b70") },
                    { new Guid("8c6e2da6-ce23-4b6f-b980-348fb630c3eb"), "123 street", new DateTime(2023, 4, 5, 13, 23, 35, 509, DateTimeKind.Utc).AddTicks(4706), "dept", "Matt", "Ingram", "Male", new Guid("ef7a7e47-3a9a-4e85-b23b-8b9724581793") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "Id",
                keyValue: new Guid("16975232-3c77-4d04-b6a4-e487c7543a1b"));

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "Id",
                keyValue: new Guid("8c6e2da6-ce23-4b6f-b980-348fb630c3eb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: new Guid("16975232-3c77-4d04-b6a4-e487c7543a1b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: new Guid("8c6e2da6-ce23-4b6f-b980-348fb630c3eb"));
        }
    }
}
