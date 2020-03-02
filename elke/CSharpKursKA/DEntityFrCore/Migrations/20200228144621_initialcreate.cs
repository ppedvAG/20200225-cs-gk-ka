using Microsoft.EntityFrameworkCore.Migrations;

namespace DEntityFrCore.Migrations
{
    public partial class initialcreate : Migration
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
                    AnschriftID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Adresszeile = table.Column<string>(nullable: true),
                    PLZ = table.Column<int>(nullable: false),
                    KundenID = table.Column<int>(nullable: false),
                    KundeInAnschriftKundenId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anschriften", x => x.AnschriftID);
                    table.ForeignKey(
                        name: "FK_Anschriften_Kunden_KundeInAnschriftKundenId",
                        column: x => x.KundeInAnschriftKundenId,
                        principalTable: "Kunden",
                        principalColumn: "KundenId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anschriften_KundeInAnschriftKundenId",
                table: "Anschriften",
                column: "KundeInAnschriftKundenId");
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
