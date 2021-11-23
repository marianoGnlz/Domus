using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domus.Migrations
{
    public partial class NoDocumentacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corporativos_Documentaciones_DocumentacionIdDocumentacion",
                table: "Corporativos");

            migrationBuilder.DropForeignKey(
                name: "FK_Particulares_Documentaciones_DocumentacionIdDocumentacion",
                table: "Particulares");

            migrationBuilder.DropTable(
                name: "Documentaciones");

            migrationBuilder.DropIndex(
                name: "IX_Particulares_DocumentacionIdDocumentacion",
                table: "Particulares");

            migrationBuilder.DropIndex(
                name: "IX_Corporativos_DocumentacionIdDocumentacion",
                table: "Corporativos");

            migrationBuilder.DropColumn(
                name: "DocumentacionIdDocumentacion",
                table: "Particulares");

            migrationBuilder.DropColumn(
                name: "DocumentacionIdDocumentacion",
                table: "Corporativos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocumentacionIdDocumentacion",
                table: "Particulares",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DocumentacionIdDocumentacion",
                table: "Corporativos",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Particulares_DocumentacionIdDocumentacion",
                table: "Particulares",
                column: "DocumentacionIdDocumentacion");

            migrationBuilder.CreateIndex(
                name: "IX_Corporativos_DocumentacionIdDocumentacion",
                table: "Corporativos",
                column: "DocumentacionIdDocumentacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Corporativos_Documentaciones_DocumentacionIdDocumentacion",
                table: "Corporativos",
                column: "DocumentacionIdDocumentacion",
                principalTable: "Documentaciones",
                principalColumn: "IdDocumentacion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Particulares_Documentaciones_DocumentacionIdDocumentacion",
                table: "Particulares",
                column: "DocumentacionIdDocumentacion",
                principalTable: "Documentaciones",
                principalColumn: "IdDocumentacion",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
