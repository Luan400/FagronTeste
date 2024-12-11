using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pontuacao.Migrations
{
    /// <inheritdoc />
    public partial class AddVezesQuebrouRecordeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "vezesQuebrouRecorde",
                table: "Resultados",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "vezesQuebrouRecorde",
                table: "Resultados");
        }
    }
}
