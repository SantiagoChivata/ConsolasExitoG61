using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsolasExitoG61.App.Persistencia.Migrations
{
    public partial class PrimerIngresoEmpleado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "primerIngreso",
                table: "persona",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "primerIngreso",
                table: "persona");
        }
    }
}
