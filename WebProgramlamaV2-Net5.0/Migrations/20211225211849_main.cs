using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgramlamaV2_Net5._0.Migrations
{
    public partial class main : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPersistent = table.Column<bool>(type: "bit", nullable: false),
                    Rolename = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Basvurular",
                columns: table => new
                {
                    kayitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsilaniId = table.Column<int>(type: "int", nullable: false),
                    PatronId = table.Column<int>(type: "int", nullable: false),
                    yazilimciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basvurular", x => x.kayitId);
                });

            migrationBuilder.CreateTable(
                name: "isilanlari",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sirketismi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lokasyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pozisyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deneyim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_isilanlari", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "patronlar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sirket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPersistent = table.Column<bool>(type: "bit", nullable: false),
                    Rolename = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patronlar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "yazilimcilar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    progLang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPersistent = table.Column<bool>(type: "bit", nullable: false),
                    Rolename = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yazilimcilar", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Basvurular");

            migrationBuilder.DropTable(
                name: "isilanlari");

            migrationBuilder.DropTable(
                name: "patronlar");

            migrationBuilder.DropTable(
                name: "yazilimcilar");
        }
    }
}
