using Microsoft.EntityFrameworkCore.Migrations;

namespace VitallyVeg.Migrations
{
    public partial class Next : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecipeImage",
                table: "Recipes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2021/03/Vegan-Hot-Wings.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2020/07/Vegan-Donuts.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2020/05/Fresh-Rolls.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2020/08/Udon-Stir-Fry.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2020/07/IMG_0917.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2020/06/Pozole-Verde-.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2020/06/Potato-Poblano-Tacos.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2020/12/Chile-Colorado-.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2020/06/Vegan-Almond-Poppy-Seed.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2020/08/Buffalo-Jack-Sliders.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2020/07/Vegan-Thai-Curry.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 12,
                column: "RecipeImage",
                value: "https://vitallyveg.com/wp-content/uploads/2020/06/Vegan-Spanakopita.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipeImage",
                table: "Recipes");
        }
    }
}
