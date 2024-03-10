using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace database.Migrations
{
    // Initial migration class to create the database schema
    public partial class InitialCreate : Migration
    {
        // Method to apply changes when migrating forward
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create the "Users" table with "Id" as primary key
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        // Method to revert changes when migrating backward
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the "Users" table
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
