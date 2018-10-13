using Microsoft.EntityFrameworkCore.Migrations;

namespace Warsztaty.Core.Migrations
{
    public partial class lala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Contact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Contact",
                nullable: false,
                defaultValue: false);
        }
    }
}
