using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidasDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class relationBetweenCompanyCreditAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyOwnerId",
                table: "CompanyCredits",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "1b05a6c5-7dec-4893-a979-471de140a852",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "38100c2c-f4a0-424f-9f8e-87f441b5e827",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "4f935728-481e-44ad-bb41-fdab4869a104",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "62c1c057-efb3-4f8e-9906-43942151ce14",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "6793a561-f2b8-410b-80c6-e45071080294",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "6c74507c-3b8a-4b98-94e3-aaa8a6a0c03b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "8250fdef-5dc8-4a8a-b252-fe0e1d7d49f8",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "88c0db84-8345-4c7c-945a-26d5853c4c05",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "9d09bc01-4e81-441e-82d2-7e3dfe7546e6",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "adc7c804-193f-48e7-ab1d-6590e5983310",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "b7c176d8-c7b2-400e-aa8f-3c3bf44c71f4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "dc6fabd5-6ed0-4e88-8849-86c867fd4771",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "e69d5415-6dcf-4863-92a9-30e0401461fb",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "eea804c5-0bfd-46d8-a9f8-32a724726a1e",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "1c7a0718-23d2-4f40-b0b0-9660b71124c9",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "641bf0b4-73cd-4e79-b8cf-6317c55d88f3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "b7ef6638-3077-4d8a-815f-6885edfe14a2",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "ba4289cb-c761-470f-a1b1-03c4e391ca64",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "c40544f0-a4d0-4cb4-9d83-8ce395496ea3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "e4e433de-f9bc-4c29-92a8-1e01240cbf12",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "e64ba268-3bba-4df1-aabd-3a3af2a2d05c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "009fadbc-f3b3-4673-823f-f69783cf8a82",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "0c9025cc-2085-4deb-9726-4227df85e546",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "14332fcf-925a-45d5-8bfc-dfee96f16855",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "1af41642-cb1f-43b9-b276-06cf1cc9e24f",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "1de07e9a-4549-4ef0-9149-95fcfb8c6db5",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "23e2f177-2bcd-4262-a171-743267a6d3d4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "287299b2-a882-411d-8f93-52354a1bf3a4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "28a67009-fb09-4136-bd97-71698faec47a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "2e7a21c6-2fe4-4c18-8c65-9e0f05423bdd",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "3c8aa9c4-22ad-4d85-9fb3-523242a75ec5",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "3d7948d7-5d17-45fe-8e93-1f0da83c138d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "4aa8236c-0a11-484a-8823-45148d7827d5",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "531b275f-7e7d-43ea-ad3f-bea09c346c45",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "54aa93fe-9a3c-49df-83a1-ddd77f60e7cf",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "65e2fb51-ea29-4b79-bb8b-44867608e588",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "66998491-8591-4255-86cf-c853ac33a335",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "6e357876-73cd-41a6-9691-89f53bb8f39d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "6f4960ff-392a-4f50-90f3-7c9169940e6d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "746a75aa-dcf6-42b5-91a8-47788387ef26",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "7d69cd4a-0b3e-4c41-a801-1cf1012ab13c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "7e89aa26-55e6-4056-b34e-9fbcc55898c4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "886533a2-a68f-45de-828c-e3320671facd",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "8ea293be-d587-4a64-b2f6-4eea78a02187",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "961b6103-033e-4290-b64c-f072ebcaa8de",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "9cd53a54-ba51-494d-8167-ab763096af5e",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "a20ff930-cbba-466a-a3ef-acb046e50359",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "b28de821-4eb8-42ad-9caf-5097e9c1ddac",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "b6229a2a-4848-469a-9345-65acb60df6e5",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "be6f0890-2c59-44bf-b334-0032f236242c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "ce4b8a5d-2c59-44bf-b334-0032f236242c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "d13134fb-61d6-4ca2-a107-4a0648e4db4f",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "d89fa8a3-6701-4ea6-96b0-5ade9c5ddef9",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "def84e18-144e-4b4a-b900-024d22c389b9",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "e27db493-6614-4e69-ac04-9121b2cbe83b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "e4e55e4a-f42b-4d38-bf8a-dff81f55e302",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "ead6807b-2852-43c8-aa4d-42caa0fd02ba",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "f8c3366e-dc73-4376-89e6-66980f4fe4ce",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "00a357b8-990e-43ac-99c3-4e7312ce4416",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "0ef9590b-875d-408e-9642-32b6bac23ddf",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "0f4f8a37-859a-4398-9324-6766a3b34d74",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "16358396-d6d8-4868-a998-72d46370adae",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "172d8827-30b5-46b2-9a45-87b87ede3193",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "176bb457-91de-4e1e-ac1c-52b901160225",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2d3f6b89-8158-4c13-a1b2-08efe7a70fa3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "36f10aef-fed8-4305-939c-27c8905482a4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "41245942-85e4-41f3-8a25-863bb42d5246",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4868a839-6cdd-4b2e-a1a6-39432c803e14",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "506203f4-c027-484c-b94f-c21c76fb3e97",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "52ab62e2-d2f3-4230-97ed-02891ea8274a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "6e5c3799-606d-46d3-b191-1da8fdaf38d6",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "71f90e92-d5e6-4b2f-bfda-06dd7106a0ab",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77a016a8-b63e-425f-acae-e0d878f7e35c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "7afd6f20-897a-4091-b804-3d94eefc8a9b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "8ed7d069-12d9-4c09-8899-953850e933d4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "9a361418-0cdb-4068-aaff-253afb9cfdb0",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a1a39d8e-3d38-4390-b285-393aa0d48a85",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a2346728-6d14-4392-af09-4d3ecd917ef3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a3e67ead-40eb-47a9-ac0c-636fbe9b2aa6",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a4509803-3652-40dd-a425-d9d36ccdad7c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a8c81edd-ed3d-416a-9ea8-b5943bfca14e",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a97b23fc-3c0a-451c-aa30-85c36e602293",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "ae8146a2-e35a-43b9-ae53-7c6f04922042",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "b07ad10d-a283-4533-832d-88ddad04e795",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "b0f70a98-f3ca-4265-bd78-d29f39a4175e",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "b7f3d073-c897-4993-b171-837a1d96dc6a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "bacf7410-b6d4-4558-8422-8cb63d1e1b1c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "c0556eb8-cc50-45ab-9cf0-d41609c4f8df",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "c509b759-87f4-44e5-8fb2-9abefd16a01d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "ce846670-cc6c-4d76-8673-4cb778bfaf27",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "cf46e31d-6ba0-4e9a-8db8-e412e8cc06d7",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "d306ed9f-5a1f-42f9-aed0-9c125b26398a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "d89e1f90-1efc-485b-9bbb-bd5a887beaeb",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "dcaec7fd-d140-4ebf-8654-0322c7376766",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "dd5b78a8-5906-441d-b255-effb9deb4b3e",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "e9ea3de4-bc06-4d69-b232-f6e163de65e4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0ca5493b-903d-4863-8194-f1a2925f2088",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "15bbe07e-c6e8-4a82-bedf-4a4303594292",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1f7e704a-d720-49bb-9129-a317cb79756a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "445e48a4-f3f6-4660-96d7-82505bc740d3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "fb0ea19a-7d05-4b0a-9532-59138d1a7bad",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "0a794282-ef06-4e94-a567-e3aadcdb4f22",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "10ec0309-bda9-41a8-b366-44d3a901f431",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "12d1fba7-cc1b-4cd0-bd9c-060bad09f79c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "13ae4b0f-4059-4962-9e34-c9a6fa61b4f3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "19c0c127-d4b5-4ccc-a9e0-0fd934621aa8",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "2d8a5faf-395e-4c89-aa74-95aa264b8d3d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "39eaed2a-63d4-47fb-8270-caa5ad8803c9",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "552500b3-f1fe-4421-a64b-fe1dc3911347",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "55dc334e-4e28-4ce2-bdba-2c0b0429dd39",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "56d332f7-c44c-417a-9655-ade356d09549",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "925a7f89-9d21-411c-800c-5ac7c47b152f",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "a4efc8b0-b662-4745-b414-704ef5081bac",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "ba70f8d4-86be-4b64-a262-159a5c771171",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "e6209b8b-511c-490e-8ba8-b732eca766b2",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "f218305e-4358-4001-87d1-71a63f252bc4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "f5f8ee19-bf92-4049-a2e5-4ef682b41750",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41dfada5-6c53-4c7b-8c07-89037e511874",
                columns: new[] { "CreatedAt", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9686), new DateTime(2024, 5, 14, 14, 25, 12, 549, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "325d131a-195e-422d-9e72-2ab306fe5ca7",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "34365695-fcff-454b-8f3e-0b4bcbf63780",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "39baff07-06f8-4702-b313-2e26807d1d1b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "3c83b90f-1de1-4444-8039-afd777e2f080",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "3d1c4668-07e3-4456-a066-7991e231037d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "45f38282-072d-49e1-885a-d7420b63ad9a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "46216ca1-14fb-4361-afb0-8e7cc9ff485b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "4b1401bf-3619-44df-8191-6516e4b65397",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "56effc3e-cca8-4c9c-adcb-ee69dfebecbd",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "596fc007-022c-4c8f-9633-f8a22f487d66",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "59a370b6-0db0-4f5e-8d2a-d5835b38d242",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "79f1dc3a-50ba-4223-96d1-1ad1f1585904",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "82718aa0-9400-499a-8acc-89ef5b9e9ca2",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "8f836995-92ca-4d16-aef9-940e1a79c2cf",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "9360a076-35ab-4bf7-b267-62b2a79fc0a9",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "93fd0c5d-a66a-4434-b617-e1762caf666b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "a53b4bd8-ea83-4dc5-b615-dcdf3e9535d6",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "a97032a3-b3ba-4bd8-9927-f27fe70ec36d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "bf1f59a3-8d4f-42f3-95c1-fc5a26d15e1d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "e6f007cd-5103-422d-b33c-0a7fa8a1c657",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "eaecb320-e5b9-4396-92e0-4d8c7b4cc7a4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "f06d56e7-b092-4665-948f-b89426ca8d0f",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 25, 12, 550, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCredits_CompanyOwnerId",
                table: "CompanyCredits",
                column: "CompanyOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK__CompanyCr__User",
                table: "CompanyCredits",
                column: "CompanyOwnerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__CompanyCr__User",
                table: "CompanyCredits");

            migrationBuilder.DropIndex(
                name: "IX_CompanyCredits_CompanyOwnerId",
                table: "CompanyCredits");

            migrationBuilder.DropColumn(
                name: "CompanyOwnerId",
                table: "CompanyCredits");

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "1b05a6c5-7dec-4893-a979-471de140a852",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "38100c2c-f4a0-424f-9f8e-87f441b5e827",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "4f935728-481e-44ad-bb41-fdab4869a104",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "62c1c057-efb3-4f8e-9906-43942151ce14",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "6793a561-f2b8-410b-80c6-e45071080294",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "6c74507c-3b8a-4b98-94e3-aaa8a6a0c03b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "8250fdef-5dc8-4a8a-b252-fe0e1d7d49f8",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "88c0db84-8345-4c7c-945a-26d5853c4c05",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "9d09bc01-4e81-441e-82d2-7e3dfe7546e6",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "adc7c804-193f-48e7-ab1d-6590e5983310",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "b7c176d8-c7b2-400e-aa8f-3c3bf44c71f4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "dc6fabd5-6ed0-4e88-8849-86c867fd4771",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "e69d5415-6dcf-4863-92a9-30e0401461fb",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: "eea804c5-0bfd-46d8-a9f8-32a724726a1e",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "1c7a0718-23d2-4f40-b0b0-9660b71124c9",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "641bf0b4-73cd-4e79-b8cf-6317c55d88f3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "b7ef6638-3077-4d8a-815f-6885edfe14a2",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "ba4289cb-c761-470f-a1b1-03c4e391ca64",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "c40544f0-a4d0-4cb4-9d83-8ce395496ea3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "e4e433de-f9bc-4c29-92a8-1e01240cbf12",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "e64ba268-3bba-4df1-aabd-3a3af2a2d05c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "009fadbc-f3b3-4673-823f-f69783cf8a82",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "0c9025cc-2085-4deb-9726-4227df85e546",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "14332fcf-925a-45d5-8bfc-dfee96f16855",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "1af41642-cb1f-43b9-b276-06cf1cc9e24f",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "1de07e9a-4549-4ef0-9149-95fcfb8c6db5",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "23e2f177-2bcd-4262-a171-743267a6d3d4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "287299b2-a882-411d-8f93-52354a1bf3a4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "28a67009-fb09-4136-bd97-71698faec47a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "2e7a21c6-2fe4-4c18-8c65-9e0f05423bdd",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "3c8aa9c4-22ad-4d85-9fb3-523242a75ec5",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "3d7948d7-5d17-45fe-8e93-1f0da83c138d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "4aa8236c-0a11-484a-8823-45148d7827d5",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "531b275f-7e7d-43ea-ad3f-bea09c346c45",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "54aa93fe-9a3c-49df-83a1-ddd77f60e7cf",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "65e2fb51-ea29-4b79-bb8b-44867608e588",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "66998491-8591-4255-86cf-c853ac33a335",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "6e357876-73cd-41a6-9691-89f53bb8f39d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "6f4960ff-392a-4f50-90f3-7c9169940e6d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "746a75aa-dcf6-42b5-91a8-47788387ef26",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "7d69cd4a-0b3e-4c41-a801-1cf1012ab13c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "7e89aa26-55e6-4056-b34e-9fbcc55898c4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "886533a2-a68f-45de-828c-e3320671facd",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "8ea293be-d587-4a64-b2f6-4eea78a02187",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "961b6103-033e-4290-b64c-f072ebcaa8de",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "9cd53a54-ba51-494d-8167-ab763096af5e",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "a20ff930-cbba-466a-a3ef-acb046e50359",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "b28de821-4eb8-42ad-9caf-5097e9c1ddac",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "b6229a2a-4848-469a-9345-65acb60df6e5",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "be6f0890-2c59-44bf-b334-0032f236242c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "ce4b8a5d-2c59-44bf-b334-0032f236242c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "d13134fb-61d6-4ca2-a107-4a0648e4db4f",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "d89fa8a3-6701-4ea6-96b0-5ade9c5ddef9",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "def84e18-144e-4b4a-b900-024d22c389b9",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "e27db493-6614-4e69-ac04-9121b2cbe83b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "e4e55e4a-f42b-4d38-bf8a-dff81f55e302",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "ead6807b-2852-43c8-aa4d-42caa0fd02ba",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "f8c3366e-dc73-4376-89e6-66980f4fe4ce",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "00a357b8-990e-43ac-99c3-4e7312ce4416",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "0ef9590b-875d-408e-9642-32b6bac23ddf",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "0f4f8a37-859a-4398-9324-6766a3b34d74",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "16358396-d6d8-4868-a998-72d46370adae",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "172d8827-30b5-46b2-9a45-87b87ede3193",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "176bb457-91de-4e1e-ac1c-52b901160225",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2d3f6b89-8158-4c13-a1b2-08efe7a70fa3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "36f10aef-fed8-4305-939c-27c8905482a4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "41245942-85e4-41f3-8a25-863bb42d5246",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4868a839-6cdd-4b2e-a1a6-39432c803e14",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "506203f4-c027-484c-b94f-c21c76fb3e97",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "52ab62e2-d2f3-4230-97ed-02891ea8274a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "6e5c3799-606d-46d3-b191-1da8fdaf38d6",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "71f90e92-d5e6-4b2f-bfda-06dd7106a0ab",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77a016a8-b63e-425f-acae-e0d878f7e35c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "7afd6f20-897a-4091-b804-3d94eefc8a9b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "8ed7d069-12d9-4c09-8899-953850e933d4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "9a361418-0cdb-4068-aaff-253afb9cfdb0",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a1a39d8e-3d38-4390-b285-393aa0d48a85",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a2346728-6d14-4392-af09-4d3ecd917ef3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a3e67ead-40eb-47a9-ac0c-636fbe9b2aa6",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a4509803-3652-40dd-a425-d9d36ccdad7c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a8c81edd-ed3d-416a-9ea8-b5943bfca14e",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a97b23fc-3c0a-451c-aa30-85c36e602293",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "ae8146a2-e35a-43b9-ae53-7c6f04922042",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "b07ad10d-a283-4533-832d-88ddad04e795",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "b0f70a98-f3ca-4265-bd78-d29f39a4175e",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "b7f3d073-c897-4993-b171-837a1d96dc6a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "bacf7410-b6d4-4558-8422-8cb63d1e1b1c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "c0556eb8-cc50-45ab-9cf0-d41609c4f8df",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "c509b759-87f4-44e5-8fb2-9abefd16a01d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "ce846670-cc6c-4d76-8673-4cb778bfaf27",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "cf46e31d-6ba0-4e9a-8db8-e412e8cc06d7",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "d306ed9f-5a1f-42f9-aed0-9c125b26398a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "d89e1f90-1efc-485b-9bbb-bd5a887beaeb",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "dcaec7fd-d140-4ebf-8654-0322c7376766",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "dd5b78a8-5906-441d-b255-effb9deb4b3e",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "e9ea3de4-bc06-4d69-b232-f6e163de65e4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0ca5493b-903d-4863-8194-f1a2925f2088",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "15bbe07e-c6e8-4a82-bedf-4a4303594292",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1f7e704a-d720-49bb-9129-a317cb79756a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "445e48a4-f3f6-4660-96d7-82505bc740d3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "fb0ea19a-7d05-4b0a-9532-59138d1a7bad",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "0a794282-ef06-4e94-a567-e3aadcdb4f22",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "10ec0309-bda9-41a8-b366-44d3a901f431",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "12d1fba7-cc1b-4cd0-bd9c-060bad09f79c",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "13ae4b0f-4059-4962-9e34-c9a6fa61b4f3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "19c0c127-d4b5-4ccc-a9e0-0fd934621aa8",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "2d8a5faf-395e-4c89-aa74-95aa264b8d3d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "39eaed2a-63d4-47fb-8270-caa5ad8803c9",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "552500b3-f1fe-4421-a64b-fe1dc3911347",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "55dc334e-4e28-4ce2-bdba-2c0b0429dd39",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "56d332f7-c44c-417a-9655-ade356d09549",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "925a7f89-9d21-411c-800c-5ac7c47b152f",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "a4efc8b0-b662-4745-b414-704ef5081bac",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "ba70f8d4-86be-4b64-a262-159a5c771171",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "e6209b8b-511c-490e-8ba8-b732eca766b2",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "f218305e-4358-4001-87d1-71a63f252bc4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "f5f8ee19-bf92-4049-a2e5-4ef682b41750",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41dfada5-6c53-4c7b-8c07-89037e511874",
                columns: new[] { "CreatedAt", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8813), new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "325d131a-195e-422d-9e72-2ab306fe5ca7",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "34365695-fcff-454b-8f3e-0b4bcbf63780",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "39baff07-06f8-4702-b313-2e26807d1d1b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "3c83b90f-1de1-4444-8039-afd777e2f080",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "3d1c4668-07e3-4456-a066-7991e231037d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "45f38282-072d-49e1-885a-d7420b63ad9a",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "46216ca1-14fb-4361-afb0-8e7cc9ff485b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "4b1401bf-3619-44df-8191-6516e4b65397",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "56effc3e-cca8-4c9c-adcb-ee69dfebecbd",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "596fc007-022c-4c8f-9633-f8a22f487d66",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "59a370b6-0db0-4f5e-8d2a-d5835b38d242",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "79f1dc3a-50ba-4223-96d1-1ad1f1585904",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "82718aa0-9400-499a-8acc-89ef5b9e9ca2",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "8f836995-92ca-4d16-aef9-940e1a79c2cf",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "9360a076-35ab-4bf7-b267-62b2a79fc0a9",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "93fd0c5d-a66a-4434-b617-e1762caf666b",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "a53b4bd8-ea83-4dc5-b615-dcdf3e9535d6",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "a97032a3-b3ba-4bd8-9927-f27fe70ec36d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "bf1f59a3-8d4f-42f3-95c1-fc5a26d15e1d",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "e6f007cd-5103-422d-b33c-0a7fa8a1c657",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "eaecb320-e5b9-4396-92e0-4d8c7b4cc7a4",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "f06d56e7-b092-4665-948f-b89426ca8d0f",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 11, 47, 54, 258, DateTimeKind.Local).AddTicks(9454));
        }
    }
}
