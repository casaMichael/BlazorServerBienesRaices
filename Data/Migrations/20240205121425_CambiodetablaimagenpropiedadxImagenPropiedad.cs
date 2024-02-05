using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerBienesRaices.Data.Migrations
{
    /// <inheritdoc />
    public partial class CambiodetablaimagenpropiedadxImagenPropiedad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imagenPropiedad_Propiedad_PropiedadId",
                table: "imagenPropiedad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_imagenPropiedad",
                table: "imagenPropiedad");

            migrationBuilder.RenameTable(
                name: "imagenPropiedad",
                newName: "ImagenPropiedad");

            migrationBuilder.RenameIndex(
                name: "IX_imagenPropiedad_PropiedadId",
                table: "ImagenPropiedad",
                newName: "IX_ImagenPropiedad_PropiedadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImagenPropiedad",
                table: "ImagenPropiedad",
                column: "IdImagen");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagenPropiedad_Propiedad_PropiedadId",
                table: "ImagenPropiedad",
                column: "PropiedadId",
                principalTable: "Propiedad",
                principalColumn: "IdPropiedad",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagenPropiedad_Propiedad_PropiedadId",
                table: "ImagenPropiedad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImagenPropiedad",
                table: "ImagenPropiedad");

            migrationBuilder.RenameTable(
                name: "ImagenPropiedad",
                newName: "imagenPropiedad");

            migrationBuilder.RenameIndex(
                name: "IX_ImagenPropiedad_PropiedadId",
                table: "imagenPropiedad",
                newName: "IX_imagenPropiedad_PropiedadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_imagenPropiedad",
                table: "imagenPropiedad",
                column: "IdImagen");

            migrationBuilder.AddForeignKey(
                name: "FK_imagenPropiedad_Propiedad_PropiedadId",
                table: "imagenPropiedad",
                column: "PropiedadId",
                principalTable: "Propiedad",
                principalColumn: "IdPropiedad",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
