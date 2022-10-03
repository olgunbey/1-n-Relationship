using Microsoft.EntityFrameworkCore.Migrations;

namespace Bire_Cok_Iliski.Migrations
{
    public partial class DARARI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Kisiler",
                table: "Kisiler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kisiler",
                table: "Kisiler",
                columns: new[] { "KisilerID", "KISIAD" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Kisiler",
                table: "Kisiler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kisiler",
                table: "Kisiler",
                column: "KISIAD");
        }
    }
}
