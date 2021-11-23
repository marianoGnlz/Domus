using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domus.Migrations
{
    public partial class YaFuePropiedad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corporativos_Propiedades_PropiedadIdPropiedad",
                table: "Corporativos");

            migrationBuilder.DropForeignKey(
                name: "FK_Particulares_Propiedades_PropiedadIdPropiedad",
                table: "Particulares");

            migrationBuilder.DropTable(
                name: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_Particulares_PropiedadIdPropiedad",
                table: "Particulares");

            migrationBuilder.DropIndex(
                name: "IX_Corporativos_PropiedadIdPropiedad",
                table: "Corporativos");

            migrationBuilder.DropColumn(
                name: "PropiedadIdPropiedad",
                table: "Particulares");

            migrationBuilder.DropColumn(
                name: "PropiedadIdPropiedad",
                table: "Corporativos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PropiedadIdPropiedad",
                table: "Particulares",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PropiedadIdPropiedad",
                table: "Corporativos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Propiedades",
                columns: table => new
                {
                    IdPropiedad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Antiguedad = table.Column<int>(type: "int", nullable: false),
                    Artefactos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantBanios = table.Column<int>(type: "int", nullable: false),
                    CantHabitaciones = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Espacios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Servicios = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades", x => x.IdPropiedad);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Particulares_PropiedadIdPropiedad",
                table: "Particulares",
                column: "PropiedadIdPropiedad");

            migrationBuilder.CreateIndex(
                name: "IX_Corporativos_PropiedadIdPropiedad",
                table: "Corporativos",
                column: "PropiedadIdPropiedad");

            migrationBuilder.AddForeignKey(
                name: "FK_Corporativos_Propiedades_PropiedadIdPropiedad",
                table: "Corporativos",
                column: "PropiedadIdPropiedad",
                principalTable: "Propiedades",
                principalColumn: "IdPropiedad",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Particulares_Propiedades_PropiedadIdPropiedad",
                table: "Particulares",
                column: "PropiedadIdPropiedad",
                principalTable: "Propiedades",
                principalColumn: "IdPropiedad",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
