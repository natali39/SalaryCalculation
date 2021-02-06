using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Sqlite.Migrations
{
    public partial class delsub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiefSubordinates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiefSubordinates",
                columns: table => new
                {
                    ChiefId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubordinateId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });
        }
    }
}
