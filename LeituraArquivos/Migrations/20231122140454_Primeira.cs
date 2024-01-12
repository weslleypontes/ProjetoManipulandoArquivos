using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeituraArquivos.Migrations
{
    /// <inheritdoc />
    public partial class Primeira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_desti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cnpj = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    xnome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    xLgr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    xcpl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    xbairro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cmun = table.Column<int>(type: "int", nullable: false),
                    xmun = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    uf = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cep = table.Column<int>(type: "int", nullable: false),
                    cpais = table.Column<int>(type: "int", nullable: false),
                    xpais = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ie = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iest = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    crt = table.Column<int>(type: "int", nullable: false),
                    indIEDest = table.Column<int>(type: "int", nullable: false),
                    emails = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_desti", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_emit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cnpj = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cpf = table.Column<int>(type: "int", nullable: false),
                    xnome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    xfant = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    xLgr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    xcpl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    xbairro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cmun = table.Column<int>(type: "int", nullable: false),
                    xmun = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    uf = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cep = table.Column<int>(type: "int", nullable: false),
                    cpais = table.Column<int>(type: "int", nullable: false),
                    xpais = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ie = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iest = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    crt = table.Column<int>(type: "int", nullable: false),
                    indIEDest = table.Column<int>(type: "int", nullable: false),
                    emails = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_emit", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_ide",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    versao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cuf = table.Column<int>(type: "int", nullable: false),
                    cnf = table.Column<int>(type: "int", nullable: false),
                    natop = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mod = table.Column<int>(type: "int", nullable: false),
                    serie = table.Column<int>(type: "int", nullable: false),
                    nnf = table.Column<int>(type: "int", nullable: false),
                    dhemi = table.Column<DateTime>(type: "date", nullable: false),
                    dhsaient = table.Column<DateTime>(type: "date", nullable: false),
                    tpnf = table.Column<int>(type: "int", nullable: false),
                    iddest = table.Column<int>(type: "int", nullable: false),
                    cmunfg = table.Column<int>(type: "int", nullable: false),
                    tpimp = table.Column<int>(type: "int", nullable: false),
                    tpemis = table.Column<int>(type: "int", nullable: false),
                    cdv = table.Column<int>(type: "int", nullable: false),
                    tpamb = table.Column<int>(type: "int", nullable: false),
                    finnfe = table.Column<int>(type: "int", nullable: false),
                    indfinal = table.Column<int>(type: "int", nullable: false),
                    indpres = table.Column<int>(type: "int", nullable: false),
                    procEmi = table.Column<int>(type: "int", nullable: false),
                    verProc = table.Column<int>(type: "int", nullable: false),
                    Caminho = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmitentesId = table.Column<int>(type: "int", nullable: true),
                    DestinatariosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ide", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_ide_tb_desti_DestinatariosId",
                        column: x => x.DestinatariosId,
                        principalTable: "tb_desti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tb_ide_tb_emit_EmitentesId",
                        column: x => x.EmitentesId,
                        principalTable: "tb_emit",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_prod_serv",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nItem = table.Column<int>(type: "int", nullable: false),
                    cprod = table.Column<string>(type: "TEXT(60)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cean = table.Column<string>(type: "TEXT(14)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    xprod = table.Column<string>(type: "TEXT(120)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ncm = table.Column<int>(type: "int", nullable: false),
                    cfop = table.Column<string>(type: "TEXT(6)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cest = table.Column<int>(type: "int", nullable: false),
                    ucom = table.Column<string>(type: "TEXT(6)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qcom = table.Column<decimal>(type: "decimal(15,4)", nullable: false),
                    vuncom = table.Column<decimal>(type: "decimal(21,10)", nullable: false),
                    vprod = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    ceantrib = table.Column<string>(type: "TEXT(14)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    utrib = table.Column<string>(type: "TEXT(6)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qtrib = table.Column<decimal>(type: "decimal(15,4)", nullable: false),
                    vuntrib = table.Column<decimal>(type: "decimal(21,10)", nullable: false),
                    indtot = table.Column<int>(type: "int", nullable: false),
                    EmitentesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_prod_serv", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_prod_serv_tb_emit_EmitentesId",
                        column: x => x.EmitentesId,
                        principalTable: "tb_emit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tb_ide_DestinatariosId",
                table: "tb_ide",
                column: "DestinatariosId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_ide_EmitentesId",
                table: "tb_ide",
                column: "EmitentesId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_prod_serv_EmitentesId",
                table: "tb_prod_serv",
                column: "EmitentesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_ide");

            migrationBuilder.DropTable(
                name: "tb_prod_serv");

            migrationBuilder.DropTable(
                name: "tb_desti");

            migrationBuilder.DropTable(
                name: "tb_emit");
        }
    }
}
