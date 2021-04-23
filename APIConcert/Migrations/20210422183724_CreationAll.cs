using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIConcert.Migrations
{
    public partial class CreationAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concierto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreConcierto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaConcierto = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concierto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instrumento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreInstrumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoInstrumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarcaInstrumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioInstrumento = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrumento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMusico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoMusico = table.Column<int>(type: "int", nullable: false),
                    InstrumentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musico_Instrumento_InstrumentoId",
                        column: x => x.InstrumentoId,
                        principalTable: "Instrumento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConciertoMusico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConciertoId = table.Column<int>(type: "int", nullable: false),
                    MusicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConciertoMusico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConciertoMusico_Concierto_ConciertoId",
                        column: x => x.ConciertoId,
                        principalTable: "Concierto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConciertoMusico_Musico_MusicoId",
                        column: x => x.MusicoId,
                        principalTable: "Musico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConciertoMusico_ConciertoId",
                table: "ConciertoMusico",
                column: "ConciertoId");

            migrationBuilder.CreateIndex(
                name: "IX_ConciertoMusico_MusicoId",
                table: "ConciertoMusico",
                column: "MusicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Musico_InstrumentoId",
                table: "Musico",
                column: "InstrumentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConciertoMusico");

            migrationBuilder.DropTable(
                name: "Concierto");

            migrationBuilder.DropTable(
                name: "Musico");

            migrationBuilder.DropTable(
                name: "Instrumento");
        }
    }
}
