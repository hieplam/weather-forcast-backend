using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace weather_forcast_backend.Migrations
{
    public partial class add_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "CreatedAt", "FeelsLike", "Humidity", "Note", "Pressure", "Temp", "TempMax", "TempMin" },
                values: new object[] { 1, new DateTime(2021, 9, 3, 21, 10, 24, 873, DateTimeKind.Local).AddTicks(7379), 5.0, 3, "It's a sunny day", 2, 14.5, 19.0, 4.0 });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "CreatedAt", "FeelsLike", "Humidity", "Note", "Pressure", "Temp", "TempMax", "TempMin" },
                values: new object[] { 2, new DateTime(2021, 9, 3, 21, 10, 24, 875, DateTimeKind.Local).AddTicks(3668), 10.0, 1, "Let's go for a ride", 1, 18.5, 23.0, 9.0 });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "CreatedAt", "FeelsLike", "Humidity", "Note", "Pressure", "Temp", "TempMax", "TempMin" },
                values: new object[] { 3, new DateTime(2021, 9, 3, 21, 10, 24, 875, DateTimeKind.Local).AddTicks(3688), 8.0, 3, "Another beatiful day :)", 2, 15.199999999999999, 22.0, 8.0 });
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
