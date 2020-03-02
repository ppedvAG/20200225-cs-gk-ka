using Microsoft.EntityFrameworkCore.Migrations;

namespace DEntityFrCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunden",
                columns: table => new
                {
                    KundenId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KundenName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunden", x => x.KundenId);
                });

            migrationBuilder.CreateTable(
                name: "Anschriften",
                columns: table => new
                {
                    AnschriftId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Stadt = table.Column<string>(nullable: true),
                    Adresszeile = table.Column<string>(nullable: true),
                    PLZ = table.Column<int>(nullable: false),
                    KundenId = table.Column<int>(nullable: false),
                    KundeInAKundenId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anschriften", x => x.AnschriftId);
                    table.ForeignKey(
                        name: "FK_Anschriften_Kunden_KundeInAKundenId",
                        column: x => x.KundeInAKundenId,
                        principalTable: "Kunden",
                        principalColumn: "KundenId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anschriften_KundeInAKundenId",
                table: "Anschriften",
                column: "KundeInAKundenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anschriften");

            migrationBuilder.DropTable(
                name: "Kunden");
        }
    }
}
