using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerBienesRaices.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreacionModeloImagenPropiedadyRelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "imagenPropiedad",
                columns: table => new
                {
                    IdImagen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropiedadId = table.Column<int>(type: "int", nullable: false),
                    UrlImagenPropiedad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagenPropiedad", x => x.IdImagen);
                    table.ForeignKey(
                        name: "FK_imagenPropiedad_Propiedad_PropiedadId",
                        column: x => x.PropiedadId,
                        principalTable: "Propiedad",
                        principalColumn: "IdPropiedad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_imagenPropiedad_PropiedadId",
                table: "imagenPropiedad",
                column: "PropiedadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "imagenPropiedad");
        }
    }
}
