using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoEF.Migrations
{
    public partial class AdicionarCpfFuncionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cpf",
                table: "Funcionarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cpf",
                table: "Funcionarios");
        }
    }
}
