using Microsoft.EntityFrameworkCore.Migrations;

namespace back_end_crud.Migrations.Usuarios
{
    public partial class CreateMigration22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailUsuario",
                table: "Usuarios",
                type: "nvarchar(250)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailUsuario",
                table: "Usuarios");
        }
    }
}
