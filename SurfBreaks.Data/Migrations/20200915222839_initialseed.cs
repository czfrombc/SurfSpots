using Microsoft.EntityFrameworkCore.Migrations;

namespace SurfBreaks.Data.Migrations
{
    public partial class initialseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SurfBreaks",
                columns: new[] { "Id", "Break", "Location", "Name" },
                values: new object[] { 100, 1, "Oaxaca", "Puerto Escondido" });

            migrationBuilder.InsertData(
                table: "SurfBreaks",
                columns: new[] { "Id", "Break", "Location", "Name" },
                values: new object[] { 101, 3, "Oahu", "Pipeline" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SurfBreaks",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "SurfBreaks",
                keyColumn: "Id",
                keyValue: 101);
        }
    }
}
