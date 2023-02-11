using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Livraria.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddingPrecoOnLivro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Livro",
                type: "decimal(10,2)",
                nullable: false);
        }

    }
}
