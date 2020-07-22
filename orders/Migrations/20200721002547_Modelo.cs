using Microsoft.EntityFrameworkCore.Migrations;

namespace orders.Migrations
{
    public partial class Modelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ITEM = table.Column<string>(nullable: false),
                    QTD = table.Column<int>(nullable: false),
                    VALORUNITARIO = table.Column<decimal>(nullable: false),
                    TOTAL = table.Column<decimal>(nullable: false),
                    CLIENTE = table.Column<string>(nullable: false),
                    CANAL = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => new { x.ID, x.ITEM });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
