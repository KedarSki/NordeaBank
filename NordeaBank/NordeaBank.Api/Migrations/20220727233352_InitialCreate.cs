using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NordeaBank.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Worker_Ref_Id = table.Column<int>(type: "int", nullable: false),
                    Worker_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Affected_From = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Joining_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Affected_From", "Worker_Ref_Id", "Worker_Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Manager" },
                    { 2, new DateTime(2016, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Executive" },
                    { 3, new DateTime(2016, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Executive" },
                    { 4, new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Manager" },
                    { 5, new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Asst. Manager" },
                    { 6, new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Executive" },
                    { 7, new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Lead" },
                    { 8, new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Lead" }
                });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "Department", "First_Name", "Joining_Date", "Last_Name", "Salary" },
                values: new object[,]
                {
                    { 1, "HR", "Monika", new DateTime(2014, 2, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "Arora", 10000m },
                    { 2, "Admin", "Niharika", new DateTime(2014, 6, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Verma", 80000m },
                    { 3, "HR", "Vishal", new DateTime(2014, 2, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "Singhal", 300000m },
                    { 4, "Admin", "Amitabh", new DateTime(2014, 2, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "Singh", 500000m },
                    { 5, "Admin", "Vivek", new DateTime(2014, 6, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Bhati", 500000m },
                    { 6, "Account", "Vipul", new DateTime(2014, 6, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Diwan", 200000m },
                    { 7, "Account", "Satish", new DateTime(2014, 1, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "Kumar", 7500m },
                    { 8, "Admin", "Geetika", new DateTime(2014, 4, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Chauhan", 90000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}
