using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domus.Migrations
{
    public partial class PropiedadesBien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Propiedades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Propiedades");
        }
    }
}
