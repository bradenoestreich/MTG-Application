using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MTG_Application.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Uri = table.Column<string>(nullable: true),
                    ImageUri = table.Column<string>(nullable: true),
                    ManaCost = table.Column<string>(nullable: true),
                    ManaValue = table.Column<int>(nullable: false),
                    TypeLine = table.Column<string>(nullable: true),
                    Colors = table.Column<string>(nullable: true),
                    ColorIdentity = table.Column<string>(nullable: true),
                    Foil = table.Column<string>(nullable: true),
                    NonFoil = table.Column<string>(nullable: true),
                    SetCode = table.Column<string>(nullable: true),
                    SetName = table.Column<string>(nullable: true),
                    Rarity = table.Column<string>(nullable: true),
                    Artist = table.Column<string>(nullable: true),
                    Prices = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
