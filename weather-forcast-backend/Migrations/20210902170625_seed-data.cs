using Microsoft.EntityFrameworkCore.Migrations;

namespace weather_forcast_backend.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Note" },
                values: new object[] { 1, "Seed Note 1" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Note" },
                values: new object[] { 2, "Seed Note 1" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Note" },
                values: new object[] { 3, "Seed Note 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
