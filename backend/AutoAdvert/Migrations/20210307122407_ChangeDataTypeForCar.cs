using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoAdvert.Migrations
{
    public partial class ChangeDataTypeForCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Volume",
                table: "Cars",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UpdatedOn", "UploadedOn", "Volume" },
                values: new object[] { new DateTime(2021, 3, 7, 14, 24, 6, 64, DateTimeKind.Local).AddTicks(9418), new DateTime(2021, 3, 7, 14, 24, 6, 60, DateTimeKind.Local).AddTicks(6074), 203.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Volume",
                table: "Cars",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UpdatedOn", "UploadedOn", "Volume" },
                values: new object[] { new DateTime(2021, 3, 7, 14, 15, 4, 241, DateTimeKind.Local).AddTicks(577), new DateTime(2021, 3, 7, 14, 15, 4, 236, DateTimeKind.Local).AddTicks(9645), 203 });
        }
    }
}
