using Microsoft.EntityFrameworkCore.Migrations;

namespace Aldente.Data.Migrations
{
    public partial class Avemaria9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurantes_Platillos_PlatilloId",
                table: "Restaurantes");

            migrationBuilder.DropIndex(
                name: "IX_Restaurantes_PlatilloId",
                table: "Restaurantes");

            migrationBuilder.DropColumn(
                name: "PlatilloId",
                table: "Restaurantes");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Platillos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestauranteId",
                table: "Platillos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoiaId",
                table: "Platillos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Platillos_CategoriaId",
                table: "Platillos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Platillos_RestauranteId",
                table: "Platillos",
                column: "RestauranteId");

            migrationBuilder.CreateIndex(
                name: "IX_Platillos_SubCategoiaId",
                table: "Platillos",
                column: "SubCategoiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Platillos_Categorias_CategoriaId",
                table: "Platillos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Platillos_Restaurantes_RestauranteId",
                table: "Platillos",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Platillos_subCategoias_SubCategoiaId",
                table: "Platillos",
                column: "SubCategoiaId",
                principalTable: "subCategoias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Platillos_Categorias_CategoriaId",
                table: "Platillos");

            migrationBuilder.DropForeignKey(
                name: "FK_Platillos_Restaurantes_RestauranteId",
                table: "Platillos");

            migrationBuilder.DropForeignKey(
                name: "FK_Platillos_subCategoias_SubCategoiaId",
                table: "Platillos");

            migrationBuilder.DropIndex(
                name: "IX_Platillos_CategoriaId",
                table: "Platillos");

            migrationBuilder.DropIndex(
                name: "IX_Platillos_RestauranteId",
                table: "Platillos");

            migrationBuilder.DropIndex(
                name: "IX_Platillos_SubCategoiaId",
                table: "Platillos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Platillos");

            migrationBuilder.DropColumn(
                name: "RestauranteId",
                table: "Platillos");

            migrationBuilder.DropColumn(
                name: "SubCategoiaId",
                table: "Platillos");

            migrationBuilder.AddColumn<int>(
                name: "PlatilloId",
                table: "Restaurantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurantes_PlatilloId",
                table: "Restaurantes",
                column: "PlatilloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurantes_Platillos_PlatilloId",
                table: "Restaurantes",
                column: "PlatilloId",
                principalTable: "Platillos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
