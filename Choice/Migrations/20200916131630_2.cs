using Microsoft.EntityFrameworkCore.Migrations;

namespace Choice.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Teachers_TeacherId",
                table: "Disciplines");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Disciplines",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Teachers_TeacherId",
                table: "Disciplines",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Teachers_TeacherId",
                table: "Disciplines");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Disciplines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Teachers_TeacherId",
                table: "Disciplines",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
