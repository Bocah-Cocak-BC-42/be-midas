using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MidasDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addUsersAndRolesSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "445e48a4-f3f6-4660-96d7-82505bc740d3", new DateTime(2024, 4, 25, 14, 19, 3, 468, DateTimeKind.Local).AddTicks(3776), null, "Nasabah", null },
                    { "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0", new DateTime(2024, 4, 25, 14, 19, 3, 468, DateTimeKind.Local).AddTicks(3760), null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "CompanyCreditLimit", "CreatedAt", "CreatedBy", "CreditScore", "DeletedAt", "DeletedBy", "Email", "FullName", "Gender", "IdentityNumber", "NickName", "Password", "PersonalCreditLimit", "PhoneNumber", "RegistrationDate", "RoleId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, null, new DateTime(2024, 4, 25, 14, 19, 3, 468, DateTimeKind.Local).AddTicks(3864), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, null, "admin@midas.com", "Admin", "M", "AA00000001", "Admin", "", null, null, new DateTime(2024, 4, 25, 14, 19, 3, 468, DateTimeKind.Local).AddTicks(3860), "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0", null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "445e48a4-f3f6-4660-96d7-82505bc740d3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41dfada5-6c53-4c7b-8c07-89037e511874");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0");
        }
    }
}
