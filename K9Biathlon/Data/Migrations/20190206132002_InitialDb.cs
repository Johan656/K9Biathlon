using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace K9Biathlon.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deltagare",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FNamn = table.Column<string>(nullable: true),
                    ENamn = table.Column<string>(nullable: true),
                    Alder = table.Column<string>(nullable: true),
                    Kon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deltagare", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tavlingar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoppId = table.Column<int>(nullable: false),
                    Ar = table.Column<int>(nullable: false),
                    Adress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tavlingar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hundar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeltagareId = table.Column<int>(nullable: false),
                    Namn = table.Column<string>(nullable: true),
                    Alder = table.Column<string>(nullable: true),
                    Ras = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hundar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hundar_Deltagare_DeltagareId",
                        column: x => x.DeltagareId,
                        principalTable: "Deltagare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lopp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Distans = table.Column<string>(nullable: true),
                    Klass = table.Column<string>(nullable: true),
                    TavlingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lopp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lopp_Tavlingar_TavlingId",
                        column: x => x.TavlingId,
                        principalTable: "Tavlingar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Anmalningar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnmalningsDatum = table.Column<DateTime>(nullable: false),
                    DeltagareId = table.Column<int>(nullable: false),
                    LoppId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anmalningar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anmalningar_Deltagare_DeltagareId",
                        column: x => x.DeltagareId,
                        principalTable: "Deltagare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Anmalningar_Lopp_LoppId",
                        column: x => x.LoppId,
                        principalTable: "Lopp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anmalningar_DeltagareId",
                table: "Anmalningar",
                column: "DeltagareId");

            migrationBuilder.CreateIndex(
                name: "IX_Anmalningar_LoppId",
                table: "Anmalningar",
                column: "LoppId");

            migrationBuilder.CreateIndex(
                name: "IX_Hundar_DeltagareId",
                table: "Hundar",
                column: "DeltagareId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lopp_TavlingId",
                table: "Lopp",
                column: "TavlingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anmalningar");

            migrationBuilder.DropTable(
                name: "Hundar");

            migrationBuilder.DropTable(
                name: "Lopp");

            migrationBuilder.DropTable(
                name: "Deltagare");

            migrationBuilder.DropTable(
                name: "Tavlingar");
        }
    }
}
