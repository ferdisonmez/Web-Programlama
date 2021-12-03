using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgramlamaV2_Net5._0.Migrations
{
    public partial class Testmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatronId",
                table: "Basvurular");

            migrationBuilder.AddColumn<int>(
                name: "Patronid",
                table: "isilanlari",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Patronid",
                table: "isilanlari");

            migrationBuilder.AddColumn<int>(
                name: "PatronId",
                table: "Basvurular",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
