using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domus.Migrations
{
    public partial class Comienzo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documentaciones",
                columns: table => new
                {
                    IdDocumentacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentaciones", x => x.IdDocumentacion);
                });

            migrationBuilder.CreateTable(
                name: "Propiedades",
                columns: table => new
                {
                    IdPropiedad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Antiguedad = table.Column<int>(type: "int", nullable: false),
                    CantHabitaciones = table.Column<int>(type: "int", nullable: false),
                    Espacios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Servicios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantBanios = table.Column<int>(type: "int", nullable: false),
                    Artefactos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades", x => x.IdPropiedad);
                });

            migrationBuilder.CreateTable(
                name: "Corporativos",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Domicilio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CUIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NroCuenta = table.Column<int>(type: "int", nullable: false),
                    DocumentacionIdDocumentacion = table.Column<int>(type: "int", nullable: false),
                    PropiedadIdPropiedad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporativos", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Corporativos_Documentaciones_DocumentacionIdDocumentacion",
                        column: x => x.DocumentacionIdDocumentacion,
                        principalTable: "Documentaciones",
                        principalColumn: "IdDocumentacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Corporativos_Propiedades_PropiedadIdPropiedad",
                        column: x => x.PropiedadIdPropiedad,
                        principalTable: "Propiedades",
                        principalColumn: "IdPropiedad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Particulares",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNI = table.Column<int>(type: "int", nullable: false),
                    CUIL = table.Column<int>(type: "int", nullable: false),
                    FechaDeNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NroCuenta = table.Column<int>(type: "int", nullable: false),
                    DocumentacionIdDocumentacion = table.Column<int>(type: "int", nullable: false),
                    PropiedadIdPropiedad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Particulares", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Particulares_Documentaciones_DocumentacionIdDocumentacion",
                        column: x => x.DocumentacionIdDocumentacion,
                        principalTable: "Documentaciones",
                        principalColumn: "IdDocumentacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Particulares_Propiedades_PropiedadIdPropiedad",
                        column: x => x.PropiedadIdPropiedad,
                        principalTable: "Propiedades",
                        principalColumn: "IdPropiedad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Corporativos_DocumentacionIdDocumentacion",
                table: "Corporativos",
                column: "DocumentacionIdDocumentacion");

            migrationBuilder.CreateIndex(
                name: "IX_Corporativos_PropiedadIdPropiedad",
                table: "Corporativos",
                column: "PropiedadIdPropiedad");

            migrationBuilder.CreateIndex(
                name: "IX_Particulares_DocumentacionIdDocumentacion",
                table: "Particulares",
                column: "DocumentacionIdDocumentacion");

            migrationBuilder.CreateIndex(
                name: "IX_Particulares_PropiedadIdPropiedad",
                table: "Particulares",
                column: "PropiedadIdPropiedad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Corporativos");

            migrationBuilder.DropTable(
                name: "Particulares");

            migrationBuilder.DropTable(
                name: "Documentaciones");

            migrationBuilder.DropTable(
                name: "Propiedades");
        }
    }
}
