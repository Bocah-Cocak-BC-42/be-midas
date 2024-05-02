using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidasDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addUniqueProvinceName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "445e48a4-f3f6-4660-96d7-82505bc740d3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 56, 11, 193, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 56, 11, 193, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41dfada5-6c53-4c7b-8c07-89037e511874",
                columns: new[] { "CreatedAt", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 56, 11, 193, DateTimeKind.Local).AddTicks(4324), new DateTime(2024, 5, 2, 12, 56, 11, 193, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.CreateIndex(
                name: "UQ__Provinces",
                table: "Provinces",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UQ__Provinces",
                table: "Provinces");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "445e48a4-f3f6-4660-96d7-82505bc740d3",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 14, 30, 55, 138, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 14, 30, 55, 138, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41dfada5-6c53-4c7b-8c07-89037e511874",
                columns: new[] { "CreatedAt", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 4, 26, 14, 30, 55, 138, DateTimeKind.Local).AddTicks(5069), new DateTime(2024, 4, 26, 14, 30, 55, 138, DateTimeKind.Local).AddTicks(5064) });
        }
    }
}
