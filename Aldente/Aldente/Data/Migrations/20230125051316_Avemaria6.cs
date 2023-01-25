using Microsoft.EntityFrameworkCore.Migrations;

namespace Aldente.Data.Migrations
{
    public partial class Avemaria6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_subCategoias_SubCategoiaId",
                table: "Categorias");

            migrationBuilder.DropTable(
                name: "subCategoias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_SubCategoiaId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "SubCategoiaId",
                table: "Categorias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubCategoiaId",
                table: "Categorias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "subCategoias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subCategoias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_SubCategoiaId",
                table: "Categorias",
                column: "SubCategoiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_subCategoias_SubCategoiaId",
                table: "Categorias",
                column: "SubCategoiaId",
                principalTable: "subCategoias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
