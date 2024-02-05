using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerBienesRaices.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreacionTablaPropiedadyRelacionCateg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propiedad_Categoria_CategoriaID",
                table: "Propiedad");

            migrationBuilder.RenameColumn(
                name: "CategoriaID",
                table: "Propiedad",
                newName: "CategoriaIDCategoria");

            migrationBuilder.RenameIndex(
                name: "IX_Propiedad_CategoriaID",
                table: "Propiedad",
                newName: "IX_Propiedad_CategoriaIDCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedad_Categoria_CategoriaIDCategoria",
                table: "Propiedad",
                column: "CategoriaIDCategoria",
                principalTable: "Categoria",
                principalColumn: "IDCategoria",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propiedad_Categoria_CategoriaIDCategoria",
                table: "Propiedad");

            migrationBuilder.RenameColumn(
                name: "CategoriaIDCategoria",
                table: "Propiedad",
                newName: "CategoriaID");

            migrationBuilder.RenameIndex(
                name: "IX_Propiedad_CategoriaIDCategoria",
                table: "Propiedad",
                newName: "IX_Propiedad_CategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedad_Categoria_CategoriaID",
                table: "Propiedad",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "IDCategoria",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
