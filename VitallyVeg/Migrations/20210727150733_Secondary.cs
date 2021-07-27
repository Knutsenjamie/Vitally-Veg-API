using Microsoft.EntityFrameworkCore.Migrations;

namespace VitallyVeg.Migrations
{
    public partial class Secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yield",
                table: "Recipes",
                newName: "Makes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Makes",
                table: "Recipes",
                newName: "Yield");
        }
    }
}
