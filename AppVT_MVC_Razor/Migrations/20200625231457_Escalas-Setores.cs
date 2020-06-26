using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppVT_MVC_Razor.Migrations
{
    public partial class EscalasSetores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario");

            migrationBuilder.RenameTable(
                name: "Funcionario",
                newName: "Funcionarios");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CustoVT",
                table: "Funcionarios",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAdmissao",
                table: "Funcionarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Funcionarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EscalaId",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RG",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SetorId",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Escalas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EscalaTrabalho = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escalas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setores", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_EscalaId",
                table: "Funcionarios",
                column: "EscalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_SetorId",
                table: "Funcionarios",
                column: "SetorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Escalas_EscalaId",
                table: "Funcionarios",
                column: "EscalaId",
                principalTable: "Escalas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Setores_SetorId",
                table: "Funcionarios",
                column: "SetorId",
                principalTable: "Setores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Escalas_EscalaId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Setores_SetorId",
                table: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Escalas");

            migrationBuilder.DropTable(
                name: "Setores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_EscalaId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_SetorId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "CustoVT",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "DataAdmissao",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "EscalaId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "RG",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "SetorId",
                table: "Funcionarios");

            migrationBuilder.RenameTable(
                name: "Funcionarios",
                newName: "Funcionario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario",
                column: "Id");
        }
    }
}
