using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_LMS_Team3.Migrations
{
    public partial class initEmp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_T",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Emp_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Mobile = table.Column<long>(type: "bigint", nullable: false),
                    Emp_Dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Salary = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_T", x => x.Emp_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_T");
        }
    }
}
