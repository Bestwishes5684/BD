using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp3.Migrations
{
    public partial class Roma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentDB",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datarod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    FormOB = table.Column<int>(type: "int", nullable: false),
                    Russ = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Math = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    inf = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                   
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDB", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDB");
        }
    }
}
