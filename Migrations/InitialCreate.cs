using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektCS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aktorzy",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imie = table.Column<string>(maxLength: 200, nullable: false),
                    nazwisko = table.Column<string>(maxLength: 200, nullable: false),
                    data_urodzenia = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aktorzy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rezyserzy",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imie = table.Column<string>(maxLength: 200, nullable: false),
                    nazwisko = table.Column<string>(maxLength: 200, nullable: false),
                    data_urodzenia = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rezyserzy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "filmy",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tytul = table.Column<string>(maxLength: 200, nullable: false),
                    data_wydania = table.Column<DateTime>(type: "date", nullable: false),
                    gatunki = table.Column<string>(maxLength: 200, nullable: true),
                    sciezkadoobrazu = table.Column<string>(nullable: true),
                    aktor_id = table.Column<int>(nullable: false),
                    rezyser_id = table.Column<int>(nullable: false),
                    sciezka_do_pliku = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filmy", x => x.id);
                    table.ForeignKey(
                        name: "FK_filmy_aktorzy_aktor_id",
                        column: x => x.aktor_id,
                        principalTable: "aktorzy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_filmy_rezyserzy_rezyser_id",
                        column: x => x.rezyser_id,
                        principalTable: "rezyserzy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_filmy_aktor_id",
                table: "filmy",
                column: "aktor_id");

            migrationBuilder.CreateIndex(
                name: "IX_filmy_rezyser_id",
                table: "filmy",
                column: "rezyser_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "filmy");
            migrationBuilder.DropTable(name: "aktorzy");
            migrationBuilder.DropTable(name: "rezyserzy");
        }
    }
}