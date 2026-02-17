using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cardapio.Api.Migrations
{
    /// <inheritdoc />
    public partial class RelacaoPorPublicId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Itens");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoriaPublicId",
                table: "Itens",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Categorias_PublicId",
                table: "Categorias",
                column: "PublicId");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_CategoriaPublicId",
                table: "Itens",
                column: "CategoriaPublicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Categorias_CategoriaPublicId",
                table: "Itens",
                column: "CategoriaPublicId",
                principalTable: "Categorias",
                principalColumn: "PublicId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Categorias_CategoriaPublicId",
                table: "Itens");

            migrationBuilder.DropIndex(
                name: "IX_Itens_CategoriaPublicId",
                table: "Itens");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Categorias_PublicId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CategoriaPublicId",
                table: "Itens");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Itens",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
