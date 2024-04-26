using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidasDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class deletePostalCodeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__BranchOff__Posta__5AEE82B9",
                table: "BranchOffices");

            migrationBuilder.DropForeignKey(
                name: "FK__CompanyCr__Posta__01142BA1",
                table: "CompanyCredits");

            migrationBuilder.DropForeignKey(
                name: "FK__Individua__Busin__70DDC3D8",
                table: "IndividualCredits");

            migrationBuilder.DropForeignKey(
                name: "FK__Individua__Posta__6EF57B66",
                table: "IndividualCredits");

            migrationBuilder.DropTable(
                name: "PostalCodes");

            migrationBuilder.RenameColumn(
                name: "PostalCodeId",
                table: "IndividualCredits",
                newName: "VillageId");

            migrationBuilder.RenameColumn(
                name: "BusinessPostalCode",
                table: "IndividualCredits",
                newName: "BusinessVillage");

            migrationBuilder.RenameIndex(
                name: "IX_IndividualCredits_PostalCodeId",
                table: "IndividualCredits",
                newName: "IX_IndividualCredits_VillageId");

            migrationBuilder.RenameIndex(
                name: "IX_IndividualCredits_BusinessPostalCode",
                table: "IndividualCredits",
                newName: "IX_IndividualCredits_BusinessVillage");

            migrationBuilder.RenameColumn(
                name: "PostalCodeId",
                table: "CompanyCredits",
                newName: "VillageId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCredits_PostalCodeId",
                table: "CompanyCredits",
                newName: "IX_CompanyCredits_VillageId");

            migrationBuilder.RenameColumn(
                name: "PostalCodeId",
                table: "BranchOffices",
                newName: "VillageId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchOffices_PostalCodeId",
                table: "BranchOffices",
                newName: "IX_BranchOffices_VillageId");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Villages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddForeignKey(
                name: "FK__BranchOff__Vill__5AEE82B9",
                table: "BranchOffices",
                column: "VillageId",
                principalTable: "Villages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__CompanyCr__Vill__01142BA1",
                table: "CompanyCredits",
                column: "VillageId",
                principalTable: "Villages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Individua__Busin__70DDC3D8",
                table: "IndividualCredits",
                column: "BusinessVillage",
                principalTable: "Villages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Individua__Vill__6EF57B66",
                table: "IndividualCredits",
                column: "VillageId",
                principalTable: "Villages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__BranchOff__Vill__5AEE82B9",
                table: "BranchOffices");

            migrationBuilder.DropForeignKey(
                name: "FK__CompanyCr__Vill__01142BA1",
                table: "CompanyCredits");

            migrationBuilder.DropForeignKey(
                name: "FK__Individua__Busin__70DDC3D8",
                table: "IndividualCredits");

            migrationBuilder.DropForeignKey(
                name: "FK__Individua__Vill__6EF57B66",
                table: "IndividualCredits");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Villages");

            migrationBuilder.RenameColumn(
                name: "VillageId",
                table: "IndividualCredits",
                newName: "PostalCodeId");

            migrationBuilder.RenameColumn(
                name: "BusinessVillage",
                table: "IndividualCredits",
                newName: "BusinessPostalCode");

            migrationBuilder.RenameIndex(
                name: "IX_IndividualCredits_VillageId",
                table: "IndividualCredits",
                newName: "IX_IndividualCredits_PostalCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_IndividualCredits_BusinessVillage",
                table: "IndividualCredits",
                newName: "IX_IndividualCredits_BusinessPostalCode");

            migrationBuilder.RenameColumn(
                name: "VillageId",
                table: "CompanyCredits",
                newName: "PostalCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCredits_VillageId",
                table: "CompanyCredits",
                newName: "IX_CompanyCredits_PostalCodeId");

            migrationBuilder.RenameColumn(
                name: "VillageId",
                table: "BranchOffices",
                newName: "PostalCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchOffices_VillageId",
                table: "BranchOffices",
                newName: "IX_BranchOffices_PostalCodeId");

            migrationBuilder.CreateTable(
                name: "PostalCodes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VillageId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DeletedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    PostalCode = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PostalCo__3214EC0744B4C17E", x => x.Id);
                    table.ForeignKey(
                        name: "FK__PostalCod__Creat__4E88ABD4",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__PostalCod__Delet__5165187F",
                        column: x => x.DeletedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__PostalCod__Updat__5070F446",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__PostalCod__Villa__4D94879B",
                        column: x => x.VillageId,
                        principalTable: "Villages",
                        principalColumn: "Id");
                });

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
                columns: new[] { "CreatedAt", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 4, 25, 14, 39, 40, 161, DateTimeKind.Local).AddTicks(7065), new DateTime(2024, 4, 25, 14, 39, 40, 161, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.CreateIndex(
                name: "IX_PostalCodes_CreatedBy",
                table: "PostalCodes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PostalCodes_DeletedBy",
                table: "PostalCodes",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PostalCodes_UpdatedBy",
                table: "PostalCodes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PostalCodes_VillageId",
                table: "PostalCodes",
                column: "VillageId");

            migrationBuilder.AddForeignKey(
                name: "FK__BranchOff__Posta__5AEE82B9",
                table: "BranchOffices",
                column: "PostalCodeId",
                principalTable: "PostalCodes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__CompanyCr__Posta__01142BA1",
                table: "CompanyCredits",
                column: "PostalCodeId",
                principalTable: "PostalCodes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Individua__Busin__70DDC3D8",
                table: "IndividualCredits",
                column: "BusinessPostalCode",
                principalTable: "PostalCodes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Individua__Posta__6EF57B66",
                table: "IndividualCredits",
                column: "PostalCodeId",
                principalTable: "PostalCodes",
                principalColumn: "Id");
        }
    }
}
