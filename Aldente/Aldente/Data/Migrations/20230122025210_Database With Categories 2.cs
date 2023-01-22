using Microsoft.EntityFrameworkCore.Migrations;

namespace Aldente.Data.Migrations
{
    public partial class DatabaseWithCategories2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Platillos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Platillos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
