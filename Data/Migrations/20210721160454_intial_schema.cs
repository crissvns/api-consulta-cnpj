using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_consulta_cnpj.Data.Migrations
{
    public partial class intial_schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "consultacnpj",
                columns: table => new
                {
                    cnpj = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    dadoscnpj = table.Column<string>(type: "text", nullable: false),
                    dataultimaatualizacao = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_advogado", x => x.cnpj);
                },
                comment: "Advogados");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "consultacnpj");
        }
    }
}
