using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Sqlite.Migrations
{
    public partial class addsub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiefSubordinates",
                columns: table => new
                {
                    ChiefId = table.Column<int>(nullable: false),
                    SubordinateId = table.Column<int>(nullable: false)
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiefSubordinates");
        }
    }
}
