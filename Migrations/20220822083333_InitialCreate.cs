using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "anime",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anime", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sexo",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sexo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personaje",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Foto = table.Column<string>(type: "TEXT", nullable: false),
                    Pronunciacion = table.Column<string>(type: "TEXT", nullable: false),
                    Habilidad = table.Column<string>(type: "TEXT", nullable: false),
                    Frase = table.Column<string>(type: "TEXT", nullable: false),
                    Vestimenta = table.Column<string>(type: "TEXT", nullable: false),
                    Altura = table.Column<float>(type: "REAL", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Latitud = table.Column<string>(type: "TEXT", nullable: false),
                    Longitud = table.Column<string>(type: "TEXT", nullable: false),
                    animeid = table.Column<int>(type: "INTEGER", nullable: false),
                    Sexoid = table.Column<int>(type: "INTEGER", nullable: false),
                    Estadosid = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personaje", x => x.id);
                    table.ForeignKey(
                        name: "FK_personaje_anime_animeid",
                        column: x => x.animeid,
                        principalTable: "anime",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personaje_estado_Estadosid",
                        column: x => x.Estadosid,
                        principalTable: "estado",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personaje_sexo_Sexoid",
                        column: x => x.Sexoid,
                        principalTable: "sexo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personaje_animeid",
                table: "personaje",
                column: "animeid");

            migrationBuilder.CreateIndex(
                name: "IX_personaje_Estadosid",
                table: "personaje",
                column: "Estadosid");

            migrationBuilder.CreateIndex(
                name: "IX_personaje_Sexoid",
                table: "personaje",
                column: "Sexoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personaje");

            migrationBuilder.DropTable(
                name: "anime");

            migrationBuilder.DropTable(
                name: "estado");

            migrationBuilder.DropTable(
                name: "sexo");
        }
    }
}
