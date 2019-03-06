using Microsoft.EntityFrameworkCore.Migrations;

namespace K9Biathlon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoppId",
                table: "Tavlingar");

            migrationBuilder.AlterColumn<int>(
                name: "Alder",
                table: "Hundar",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Alder",
                table: "Deltagare",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoppId",
                table: "Tavlingar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Alder",
                table: "Hundar",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Alder",
                table: "Deltagare",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
