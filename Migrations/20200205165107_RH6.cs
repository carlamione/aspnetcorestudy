using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreApp.Migrations
{
    public partial class RH6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DEPARTAMENTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEPARTAMENTO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EMPREGADO",
                columns: table => new
                {
                    Cpf = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    NomeDoMeio = table.Column<string>(maxLength: 1, nullable: true),
                    Sobrenome = table.Column<string>(maxLength: 255, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: true),
                    Endereco = table.Column<string>(maxLength: 255, nullable: true),
                    Sexo = table.Column<string>(maxLength: 2, nullable: true),
                    Salario = table.Column<decimal>(type: "numeric", nullable: false),
                    CpfSupervisor = table.Column<int>(nullable: true),
                    NroDepartamento = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPREGADO", x => x.Cpf);
                    table.ForeignKey(
                        name: "FK_EMPREGADO_DEPARTAMENTO_NroDepartamento",
                        column: x => x.NroDepartamento,
                        principalTable: "DEPARTAMENTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EMPREGADO_NroDepartamento",
                table: "EMPREGADO",
                column: "NroDepartamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EMPREGADO");

            migrationBuilder.DropTable(
                name: "DEPARTAMENTO");
        }
    }
}
