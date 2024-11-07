using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antroji_Programavimo_Praktika_Mantas_J_.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vartotojuGrupes",
                columns: table => new
                {
                    VartG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VartG_pavadinimas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VartG_adresas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vartotojuGrupes", x => x.VartG_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Naudotojai",
                columns: table => new
                {
                    naud_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    naud_vardas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    naud_pavarde = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    naud_slaptazodis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    naud_prisijungimoVardas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    naud_elPastas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    naud_telNumeris = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    naud_tipas = table.Column<string>(type: "varchar(21)", maxLength: 21, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gyv_gyvenimojiVieta = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gyv_gimimoData = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gyv_permoka = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    gyv_vartGID = table.Column<int>(type: "int", nullable: true),
                    vady_vartGID = table.Column<int>(type: "int", nullable: true),
                    adm_vyriausiasis = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naudotojai", x => x.naud_ID);
                    table.ForeignKey(
                        name: "FK_Naudotojai_vartotojuGrupes_gyv_vartGID",
                        column: x => x.gyv_vartGID,
                        principalTable: "vartotojuGrupes",
                        principalColumn: "VartG_ID");
                    table.ForeignKey(
                        name: "FK_Naudotojai_vartotojuGrupes_vady_vartGID",
                        column: x => x.vady_vartGID,
                        principalTable: "vartotojuGrupes",
                        principalColumn: "VartG_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paslaugos",
                columns: table => new
                {
                    pasl_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pasl_pavadinimas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pasl_matovienetas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pasl_ikainis = table.Column<float>(type: "float", nullable: false),
                    pasl_vartGID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paslaugos", x => x.pasl_ID);
                    table.ForeignKey(
                        name: "FK_Paslaugos_vartotojuGrupes_pasl_vartGID",
                        column: x => x.pasl_vartGID,
                        principalTable: "vartotojuGrupes",
                        principalColumn: "VartG_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mokejimai",
                columns: table => new
                {
                    mok_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    mok_pavadinimas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mok_matovienetas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mok_ikainis = table.Column<float>(type: "float", nullable: false),
                    mok_vartotojoID = table.Column<int>(type: "int", nullable: false),
                    mok_kiekis = table.Column<float>(type: "float", nullable: false),
                    mok_terminoPradzia = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    mok_terminoPabaiga = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    mok_pilnaKaina = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    mok_likutis = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mokejimai", x => x.mok_ID);
                    table.ForeignKey(
                        name: "FK_Mokejimai_Naudotojai_mok_vartotojoID",
                        column: x => x.mok_vartotojoID,
                        principalTable: "Naudotojai",
                        principalColumn: "naud_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Mokejimai_mok_vartotojoID",
                table: "Mokejimai",
                column: "mok_vartotojoID");

            migrationBuilder.CreateIndex(
                name: "IX_Naudotojai_gyv_vartGID",
                table: "Naudotojai",
                column: "gyv_vartGID");

            migrationBuilder.CreateIndex(
                name: "IX_Naudotojai_vady_vartGID",
                table: "Naudotojai",
                column: "vady_vartGID");

            migrationBuilder.CreateIndex(
                name: "IX_Paslaugos_pasl_vartGID",
                table: "Paslaugos",
                column: "pasl_vartGID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mokejimai");

            migrationBuilder.DropTable(
                name: "Paslaugos");

            migrationBuilder.DropTable(
                name: "Naudotojai");

            migrationBuilder.DropTable(
                name: "vartotojuGrupes");
        }
    }
}
