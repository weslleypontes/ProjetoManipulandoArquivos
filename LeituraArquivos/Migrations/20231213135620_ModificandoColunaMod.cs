using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeituraArquivos.Migrations
{
    /// <inheritdoc />
    public partial class ModificandoColunaMod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "mod",
                table: "tb_ide",
                newName: "modelo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "tb_ide",
                newName: "mod");
        }
    }
}
