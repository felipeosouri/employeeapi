using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Surname = table.Column<string>(maxLength: 80, nullable: false),
                    ContractType = table.Column<string>(maxLength: 20, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Amount", "ContractType", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 112m, "Monthly", "Employee 1", "Surname Employee 1" },
                    { 2, 818m, "Hourly", "Employee 2", "Surname Employee 2" },
                    { 3, 981m, "Monthly", "Employee 3", "Surname Employee 3" },
                    { 4, 481m, "Monthly", "Employee 4", "Surname Employee 4" },
                    { 5, 518m, "Monthly", "Employee 5", "Surname Employee 5" },
                    { 6, 201m, "Monthly", "Employee 6", "Surname Employee 6" },
                    { 7, 948m, "Monthly", "Employee 7", "Surname Employee 7" },
                    { 8, 439m, "Hourly", "Employee 8", "Surname Employee 8" },
                    { 9, 140m, "Hourly", "Employee 9", "Surname Employee 9" },
                    { 10, 164m, "Hourly", "Employee 10", "Surname Employee 10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
