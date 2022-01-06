using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadFun.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Funcionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    nome_completo = table.Column<string>(type: "varchar(300)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(12)", nullable: false),
                    Email = table.Column<string>(type: "varchar(256)", nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Nascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Funcionarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Funcionarios");
        }
    }
}
