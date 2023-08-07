using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace postgresExample.Migrations
{
    /// <inheritdoc />
    public partial class updateEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titlte",
                table: "Employees",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Employees",
                newName: "Titlte");
        }
    }
}
