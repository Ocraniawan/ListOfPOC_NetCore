using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ListofPOC.Migrations
{
    public partial class CoHive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Simas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Simas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CohiveQuantum",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    CohiveId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CohiveQuantum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CohiveQuantum_Simas_CohiveId",
                        column: x => x.CohiveId,
                        principalTable: "Simas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CohiveQuantum_CohiveId",
                table: "CohiveQuantum",
                column: "CohiveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CohiveQuantum");

            migrationBuilder.DropTable(
                name: "Simas");
        }
    }
}
