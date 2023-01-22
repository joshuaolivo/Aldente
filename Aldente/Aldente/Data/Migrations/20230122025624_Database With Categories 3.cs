using Microsoft.EntityFrameworkCore.Migrations;

namespace Aldente.Data.Migrations
{
    public partial class DatabaseWithCategories3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlatilloId",
                table: "subCategoias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_subCategoias_PlatilloId",
                table: "subCategoias",
                column: "PlatilloId");

            migrationBuilder.AddForeignKey(
                name: "FK_subCategoias_Platillos_PlatilloId",
                table: "subCategoias",
                column: "PlatilloId",
                principalTable: "Platillos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subCategoias_Platillos_PlatilloId",
                table: "subCategoias");

            migrationBuilder.DropIndex(
                name: "IX_subCategoias_PlatilloId",
                table: "subCategoias");

            migrationBuilder.DropColumn(
                name: "PlatilloId",
                table: "subCategoias");
        }
    }
}
