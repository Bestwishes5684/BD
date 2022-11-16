using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp3.Migrations
{
    public partial class AddMyproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "StudentDB",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "StudentDB");
        }
    }
}
