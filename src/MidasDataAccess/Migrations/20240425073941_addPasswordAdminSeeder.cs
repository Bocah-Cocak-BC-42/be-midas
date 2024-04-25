using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidasDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addPasswordAdminSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "445e48a4-f3f6-4660-96d7-82505bc740d3",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 39, 40, 161, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 39, 40, 161, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41dfada5-6c53-4c7b-8c07-89037e511874",
                columns: new[] { "CreatedAt", "Password", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 4, 25, 14, 39, 40, 161, DateTimeKind.Local).AddTicks(7065), "$2a$12$ZEqw5fRxjcndbH.TekcXq.Pvk03lJD.mzxN73qownotDhtSfJ.vdq", new DateTime(2024, 4, 25, 14, 39, 40, 161, DateTimeKind.Local).AddTicks(7048) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "445e48a4-f3f6-4660-96d7-82505bc740d3",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 19, 3, 468, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 19, 3, 468, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41dfada5-6c53-4c7b-8c07-89037e511874",
                columns: new[] { "CreatedAt", "Password", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 4, 25, 14, 19, 3, 468, DateTimeKind.Local).AddTicks(3864), "", new DateTime(2024, 4, 25, 14, 19, 3, 468, DateTimeKind.Local).AddTicks(3860) });
        }
    }
}
