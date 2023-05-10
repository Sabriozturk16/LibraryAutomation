using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class duzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Writers_WriterID",
                table: "Headings");

            migrationBuilder.AlterColumn<int>(
                name: "WriterID",
                table: "Headings",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "WritterID",
                table: "Contents",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Writers_WriterID",
                table: "Headings",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Writers_WriterID",
                table: "Headings");

            migrationBuilder.AlterColumn<int>(
                name: "WriterID",
                table: "Headings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WritterID",
                table: "Contents",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Writers_WriterID",
                table: "Headings",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
