using Microsoft.EntityFrameworkCore.Migrations;

namespace database.Migrations
{
    // Migration class to add a column to the User table
    public partial class AddColumnToUserTable : Migration
    {
        // Method to apply changes when migrating forward
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add a new column "FullName" to the "Users" table
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Users",
                nullable: true);
        }

        // Method to revert changes when migrating backward
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the "FullName" column from the "Users" table
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Users");
        }
    }
}
