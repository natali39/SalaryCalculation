using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Sqlite.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
        name: "Staffs");

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    WorkingSince = table.Column<DateTime>(nullable: false),
                    BaseSalary = table.Column<decimal>(nullable: false),
                    HasChief = table.Column<bool>(nullable: false),
                    ChiefId = table.Column<int>(nullable: false),
                    GroupDb = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
