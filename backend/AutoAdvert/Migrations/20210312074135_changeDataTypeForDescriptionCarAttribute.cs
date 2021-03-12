using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoAdvert.Migrations
{
    public partial class changeDataTypeForDescriptionCarAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BodyType", "City", "Color", "Description", "FirstRegistration", "FuelType", "Gear", "Miles", "Model", "Name", "Power", "Price", "Seats", "UpdatedOn", "UploadedOn", "Volume", "WheelPosition", "Wheels", "Year" },
                values: new object[] { 1, "Sedanas", "Vilnius", "Blue", "Katik nuo tralo, sedi ir vaziuoji", "Vokietija", "Dyzelinas", "Automatas", 200304, "A4", "Audi", 204, 20304, 6, new DateTime(2021, 3, 7, 14, 24, 6, 64, DateTimeKind.Local).AddTicks(9418), new DateTime(2021, 3, 7, 14, 24, 6, 60, DateTimeKind.Local).AddTicks(6074), 203.0, "Priekiniai", "Priekiniai", 2003 });
        }
    }
}
