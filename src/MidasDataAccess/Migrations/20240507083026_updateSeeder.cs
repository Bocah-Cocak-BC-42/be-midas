using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MidasDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BusinessSectors",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { "1c7a0718-23d2-4f40-b0b0-9660b71124c9", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4028), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Crypto", null, null },
                    { "641bf0b4-73cd-4e79-b8cf-6317c55d88f3", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4031), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Jasa", null, null },
                    { "b7ef6638-3077-4d8a-815f-6885edfe14a2", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4032), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Permainan", null, null },
                    { "ba4289cb-c761-470f-a1b1-03c4e391ca64", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4033), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Kuliner", null, null },
                    { "c40544f0-a4d0-4cb4-9d83-8ce395496ea3", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4034), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Keuangan", null, null },
                    { "e4e433de-f9bc-4c29-92a8-1e01240cbf12", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4036), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Mebel", null, null },
                    { "e64ba268-3bba-4df1-aabd-3a3af2a2d05c", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4037), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Logistik", null, null }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { "00a357b8-990e-43ac-99c3-4e7312ce4416", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4069), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Kepulauan Bangka Belitung", null, null },
                    { "0ef9590b-875d-408e-9642-32b6bac23ddf", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4071), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sulawesi Tengah", null, null },
                    { "0f4f8a37-859a-4398-9324-6766a3b34d74", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4073), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Kepulauan Riau", null, null },
                    { "16358396-d6d8-4868-a998-72d46370adae", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4074), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "DI Yogyakarta", null, null },
                    { "172d8827-30b5-46b2-9a45-87b87ede3193", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4075), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Nusa Tenggara Barat", null, null },
                    { "176bb457-91de-4e1e-ac1c-52b901160225", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4077), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Maluku", null, null },
                    { "2d3f6b89-8158-4c13-a1b2-08efe7a70fa3", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4078), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Papua Barat Daya", null, null },
                    { "36f10aef-fed8-4305-939c-27c8905482a4", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4080), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sulawesi Barat", null, null },
                    { "41245942-85e4-41f3-8a25-863bb42d5246", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4081), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Nusa Tenggara Timur (NTT)", null, null },
                    { "4868a839-6cdd-4b2e-a1a6-39432c803e14", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4083), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Jawa Tengah", null, null },
                    { "506203f4-c027-484c-b94f-c21c76fb3e97", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4084), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sumatera Utara", null, null },
                    { "52ab62e2-d2f3-4230-97ed-02891ea8274a", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4085), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Papua Tengah", null, null },
                    { "6e5c3799-606d-46d3-b191-1da8fdaf38d6", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4087), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh (NAD)", null, null },
                    { "71f90e92-d5e6-4b2f-bfda-06dd7106a0ab", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4088), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Papua Selatan", null, null },
                    { "77a016a8-b63e-425f-acae-e0d878f7e35c", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4104), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Kalimantan Timur", null, null },
                    { "7afd6f20-897a-4091-b804-3d94eefc8a9b", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4116), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Jakarta", null, null },
                    { "8ed7d069-12d9-4c09-8899-953850e933d4", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4118), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Maluku Utara", null, null },
                    { "9a361418-0cdb-4068-aaff-253afb9cfdb0", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4120), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Banten", null, null },
                    { "a1a39d8e-3d38-4390-b285-393aa0d48a85", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4121), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Jawa Timur", null, null },
                    { "a2346728-6d14-4392-af09-4d3ecd917ef3", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4122), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Papua", null, null },
                    { "a3e67ead-40eb-47a9-ac0c-636fbe9b2aa6", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4124), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Kalimantan Utara", null, null },
                    { "a4509803-3652-40dd-a425-d9d36ccdad7c", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4125), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Lampung", null, null },
                    { "a8c81edd-ed3d-416a-9ea8-b5943bfca14e", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4126), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Jawa Barat", null, null },
                    { "a97b23fc-3c0a-451c-aa30-85c36e602293", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4127), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "DKI Jakarta", null, null },
                    { "ae8146a2-e35a-43b9-ae53-7c6f04922042", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4129), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Kalimantan Tengah", null, null },
                    { "b07ad10d-a283-4533-832d-88ddad04e795", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4130), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sulawesi Tenggara", null, null },
                    { "b0f70a98-f3ca-4265-bd78-d29f39a4175e", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4131), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sumatera Barat", null, null },
                    { "b7f3d073-c897-4993-b171-837a1d96dc6a", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4132), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sulawesi Utara", null, null },
                    { "bacf7410-b6d4-4558-8422-8cb63d1e1b1c", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4134), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sulawesi Selatan", null, null },
                    { "c0556eb8-cc50-45ab-9cf0-d41609c4f8df", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4135), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Gorontalo", null, null },
                    { "c509b759-87f4-44e5-8fb2-9abefd16a01d", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4136), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sumatera Selatan", null, null },
                    { "ce846670-cc6c-4d76-8673-4cb778bfaf27", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4137), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Riau", null, null },
                    { "cf46e31d-6ba0-4e9a-8db8-e412e8cc06d7", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4139), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Kalimantan Selatan", null, null },
                    { "d306ed9f-5a1f-42f9-aed0-9c125b26398a", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4145), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Bengkulu", null, null },
                    { "d89e1f90-1efc-485b-9bbb-bd5a887beaeb", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4146), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Jambi", null, null },
                    { "dcaec7fd-d140-4ebf-8654-0322c7376766", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4148), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Bali", null, null },
                    { "dd5b78a8-5906-441d-b255-effb9deb4b3e", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4149), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Kalimantan Barat", null, null },
                    { "e9ea3de4-bc06-4d69-b232-f6e163de65e4", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4150), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Papua Pegunungan", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "445e48a4-f3f6-4660-96d7-82505bc740d3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "0ca5493b-903d-4863-8194-f1a2925f2088", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(3834), null, "Supervisor", null },
                    { "15bbe07e-c6e8-4a82-bedf-4a4303594292", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(3835), null, "Mantri", null },
                    { "1f7e704a-d720-49bb-9129-a317cb79756a", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(3836), null, "Direktur", null },
                    { "fb0ea19a-7d05-4b0a-9532-59138d1a7bad", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(3838), null, "Manager", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41dfada5-6c53-4c7b-8c07-89037e511874",
                columns: new[] { "CreatedAt", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(3981), new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Name", "ProvinceId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { "009fadbc-f3b3-4673-823f-f69783cf8a82", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4205), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Lombok Timur", "172d8827-30b5-46b2-9a45-87b87ede3193", null, null },
                    { "0c9025cc-2085-4deb-9726-4227df85e546", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4208), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Bireuen", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "14332fcf-925a-45d5-8bfc-dfee96f16855", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4209), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh Barat Daya", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "1af41642-cb1f-43b9-b276-06cf1cc9e24f", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4211), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Bener Meriah", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "1de07e9a-4549-4ef0-9149-95fcfb8c6db5", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4212), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sumbawa", "172d8827-30b5-46b2-9a45-87b87ede3193", null, null },
                    { "23e2f177-2bcd-4262-a171-743267a6d3d4", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4214), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Jembrana", "dcaec7fd-d140-4ebf-8654-0322c7376766", null, null },
                    { "287299b2-a882-411d-8f93-52354a1bf3a4", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4215), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Pidie Jaya", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "28a67009-fb09-4136-bd97-71698faec47a", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4226), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh Barat", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "2e7a21c6-2fe4-4c18-8c65-9e0f05423bdd", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4228), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Simeulue", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "3c8aa9c4-22ad-4d85-9fb3-523242a75ec5", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4218), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Mataram", "172d8827-30b5-46b2-9a45-87b87ede3193", null, null },
                    { "3d7948d7-5d17-45fe-8e93-1f0da83c138d", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4229), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Singaraja", "dcaec7fd-d140-4ebf-8654-0322c7376766", null, null },
                    { "4aa8236c-0a11-484a-8823-45148d7827d5", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4231), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh Tamiang", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "531b275f-7e7d-43ea-ad3f-bea09c346c45", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4236), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Subulussalam", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "54aa93fe-9a3c-49df-83a1-ddd77f60e7cf", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4238), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Gianyar", "dcaec7fd-d140-4ebf-8654-0322c7376766", null, null },
                    { "65e2fb51-ea29-4b79-bb8b-44867608e588", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4239), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh Selatan", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "66998491-8591-4255-86cf-c853ac33a335", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4240), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Nagan Raya", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "6e357876-73cd-41a6-9691-89f53bb8f39d", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4241), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Lhokseumawe", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "6f4960ff-392a-4f50-90f3-7c9169940e6d", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4243), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh Utara", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "746a75aa-dcf6-42b5-91a8-47788387ef26", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4244), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh Timur", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "7d69cd4a-0b3e-4c41-a801-1cf1012ab13c", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4245), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh Tengah", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "7e89aa26-55e6-4056-b34e-9fbcc55898c4", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4247), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Lombok Barat", "172d8827-30b5-46b2-9a45-87b87ede3193", null, null },
                    { "886533a2-a68f-45de-828c-e3320671facd", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4254), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Gayo Lues", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "8ea293be-d587-4a64-b2f6-4eea78a02187", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4255), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh Jaya", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "961b6103-033e-4290-b64c-f072ebcaa8de", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4257), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Yogyakarta", "16358396-d6d8-4868-a998-72d46370adae", null, null },
                    { "9cd53a54-ba51-494d-8167-ab763096af5e", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4259), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh Besar", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "a20ff930-cbba-466a-a3ef-acb046e50359", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4260), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Banda Aceh", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "b28de821-4eb8-42ad-9caf-5097e9c1ddac", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4261), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Dompu", "172d8827-30b5-46b2-9a45-87b87ede3193", null, null },
                    { "b6229a2a-4848-469a-9345-65acb60df6e5", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4217), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Langsa", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "be6f0890-2c59-44bf-b334-0032f236242c", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4220), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sabang", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "ce4b8a5d-2c59-44bf-b334-0032f236242c", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4221), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Lombok Tengah", "172d8827-30b5-46b2-9a45-87b87ede3193", null, null },
                    { "d13134fb-61d6-4ca2-a107-4a0648e4db4f", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4222), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sumbawa Barat", "172d8827-30b5-46b2-9a45-87b87ede3193", null, null },
                    { "d89fa8a3-6701-4ea6-96b0-5ade9c5ddef9", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4224), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh Tenggara", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "def84e18-144e-4b4a-b900-024d22c389b9", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4225), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Bima", "172d8827-30b5-46b2-9a45-87b87ede3193", null, null },
                    { "e27db493-6614-4e69-ac04-9121b2cbe83b", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4232), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Lombok Utara", "172d8827-30b5-46b2-9a45-87b87ede3193", null, null },
                    { "e4e55e4a-f42b-4d38-bf8a-dff81f55e302", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4234), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Tabanan", "dcaec7fd-d140-4ebf-8654-0322c7376766", null, null },
                    { "ead6807b-2852-43c8-aa4d-42caa0fd02ba", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4235), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Pidie", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null },
                    { "f8c3366e-dc73-4376-89e6-66980f4fe4ce", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4263), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aceh Singkil", "6e5c3799-606d-46d3-b191-1da8fdaf38d6", null, null }
                });

            migrationBuilder.InsertData(
                table: "SubDistricts",
                columns: new[] { "Id", "CityId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { "0a794282-ef06-4e94-a567-e3aadcdb4f22", "3c8aa9c4-22ad-4d85-9fb3-523242a75ec5", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4315), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Mataram", null, null },
                    { "10ec0309-bda9-41a8-b366-44d3a901f431", "65e2fb51-ea29-4b79-bb8b-44867608e588", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4317), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Bakongan Timur", null, null },
                    { "12d1fba7-cc1b-4cd0-bd9c-060bad09f79c", "961b6103-033e-4290-b64c-f072ebcaa8de", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4318), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Mantrijeron", null, null },
                    { "13ae4b0f-4059-4962-9e34-c9a6fa61b4f3", "65e2fb51-ea29-4b79-bb8b-44867608e588", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4320), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Kluet Tengah", null, null },
                    { "19c0c127-d4b5-4ccc-a9e0-0fd934621aa8", "7e89aa26-55e6-4056-b34e-9fbcc55898c4", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4321), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Selaparang", null, null },
                    { "2d8a5faf-395e-4c89-aa74-95aa264b8d3d", "65e2fb51-ea29-4b79-bb8b-44867608e588", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4323), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Kluet Selatan", null, null },
                    { "39eaed2a-63d4-47fb-8270-caa5ad8803c9", "961b6103-033e-4290-b64c-f072ebcaa8de", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4324), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Wirobrajan", null, null },
                    { "552500b3-f1fe-4421-a64b-fe1dc3911347", "3c8aa9c4-22ad-4d85-9fb3-523242a75ec5", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4326), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sandubaya", null, null },
                    { "55dc334e-4e28-4ce2-bdba-2c0b0429dd39", "65e2fb51-ea29-4b79-bb8b-44867608e588", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4327), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Bakongan", null, null },
                    { "56d332f7-c44c-417a-9655-ade356d09549", "3c8aa9c4-22ad-4d85-9fb3-523242a75ec5", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4329), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Selaparang", null, null },
                    { "925a7f89-9d21-411c-800c-5ac7c47b152f", "3c8aa9c4-22ad-4d85-9fb3-523242a75ec5", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4330), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Sekarbela", null, null },
                    { "a4efc8b0-b662-4745-b414-704ef5081bac", "3c8aa9c4-22ad-4d85-9fb3-523242a75ec5", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4332), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Ampenan", null, null },
                    { "ba70f8d4-86be-4b64-a262-159a5c771171", "3c8aa9c4-22ad-4d85-9fb3-523242a75ec5", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4333), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Cakranegara", null, null },
                    { "e6209b8b-511c-490e-8ba8-b732eca766b2", "009fadbc-f3b3-4673-823f-f69783cf8a82", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4334), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Jerowaru", null, null },
                    { "f218305e-4358-4001-87d1-71a63f252bc4", "009fadbc-f3b3-4673-823f-f69783cf8a82", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4336), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aikmel", null, null },
                    { "f5f8ee19-bf92-4049-a2e5-4ef682b41750", "65e2fb51-ea29-4b79-bb8b-44867608e588", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4337), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Kluet Timur", null, null }
                });

            migrationBuilder.InsertData(
                table: "Villages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Name", "PostalCode", "SubDistrictId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { "325d131a-195e-422d-9e72-2ab306fe5ca7", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4376), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Bintaro", "83118", "a4efc8b0-b662-4745-b414-704ef5081bac", null, null },
                    { "34365695-fcff-454b-8f3e-0b4bcbf63780", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4379), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Cilinaya", "83238", "ba70f8d4-86be-4b64-a262-159a5c771171", null, null },
                    { "39baff07-06f8-4702-b313-2e26807d1d1b", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4381), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Pagutan", "83117", "0a794282-ef06-4e94-a567-e3aadcdb4f22", null, null },
                    { "3c83b90f-1de1-4444-8039-afd777e2f080", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4382), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Darul Ikhsan", "23773", "55dc334e-4e28-4ce2-bdba-2c0b0429dd39", null, null },
                    { "3d1c4668-07e3-4456-a066-7991e231037d", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4389), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Tanjung Karang", "83115", "925a7f89-9d21-411c-800c-5ac7c47b152f", null, null },
                    { "45f38282-072d-49e1-885a-d7420b63ad9a", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4392), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Pakuncen", "55253", "925a7f89-9d21-411c-800c-5ac7c47b152f", null, null },
                    { "46216ca1-14fb-4361-afb0-8e7cc9ff485b", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4393), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Dasan Cermen", "83232", "552500b3-f1fe-4421-a64b-fe1dc3911347", null, null },
                    { "4b1401bf-3619-44df-8191-6516e4b65397", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4395), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Mayura", "83232", "ba70f8d4-86be-4b64-a262-159a5c771171", null, null },
                    { "56effc3e-cca8-4c9c-adcb-ee69dfebecbd", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4397), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aik Prapa", "83653", "e6209b8b-511c-490e-8ba8-b732eca766b2", null, null },
                    { "596fc007-022c-4c8f-9633-f8a22f487d66", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4399), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Padang Beurahan (Padang Berahan)", "23773", "55dc334e-4e28-4ce2-bdba-2c0b0429dd39", null, null },
                    { "59a370b6-0db0-4f5e-8d2a-d5835b38d242", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4401), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Turida", "83237", "552500b3-f1fe-4421-a64b-fe1dc3911347", null, null },
                    { "79f1dc3a-50ba-4223-96d1-1ad1f1585904", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4403), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Gampong Drien (Kampung Drien)", "23773", "55dc334e-4e28-4ce2-bdba-2c0b0429dd39", null, null },
                    { "82718aa0-9400-499a-8acc-89ef5b9e9ca2", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4404), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Ujong Padang (Ujung Padang)", "23773", "55dc334e-4e28-4ce2-bdba-2c0b0429dd39", null, null },
                    { "8f836995-92ca-4d16-aef9-940e1a79c2cf", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4406), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Karang Baru", "83123", "56d332f7-c44c-417a-9655-ade356d09549", null, null },
                    { "9360a076-35ab-4bf7-b267-62b2a79fc0a9", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4408), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Monjok Barat", "83122", "56d332f7-c44c-417a-9655-ade356d09549", null, null },
                    { "93fd0c5d-a66a-4434-b617-e1762caf666b", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4409), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Jempong Baru", "83116", "925a7f89-9d21-411c-800c-5ac7c47b152f", null, null },
                    { "a53b4bd8-ea83-4dc5-b615-dcdf3e9535d6", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4411), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Gedongkiwo", "55142", "12d1fba7-cc1b-4cd0-bd9c-060bad09f79c", null, null },
                    { "a97032a3-b3ba-4bd8-9927-f27fe70ec36d", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4414), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Ujong Mangki (Ujung Mangki)", "23773", "55dc334e-4e28-4ce2-bdba-2c0b0429dd39", null, null },
                    { "bf1f59a3-8d4f-42f3-95c1-fc5a26d15e1d", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4415), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Keude Bakongan", "23773", "55dc334e-4e28-4ce2-bdba-2c0b0429dd39", null, null },
                    { "e6f007cd-5103-422d-b33c-0a7fa8a1c657", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4417), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Pejeruk", "83113", "a4efc8b0-b662-4745-b414-704ef5081bac", null, null },
                    { "eaecb320-e5b9-4396-92e0-4d8c7b4cc7a4", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4419), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Gampong Baro (Kampung Baru)", "23773", "55dc334e-4e28-4ce2-bdba-2c0b0429dd39", null, null },
                    { "f06d56e7-b092-4665-948f-b89426ca8d0f", new DateTime(2024, 5, 7, 15, 30, 25, 226, DateTimeKind.Local).AddTicks(4420), "41dfada5-6c53-4c7b-8c07-89037e511874", null, null, "Aikmel Barat", "83653", "e6209b8b-511c-490e-8ba8-b732eca766b2", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "1c7a0718-23d2-4f40-b0b0-9660b71124c9");

            migrationBuilder.DeleteData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "641bf0b4-73cd-4e79-b8cf-6317c55d88f3");

            migrationBuilder.DeleteData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "b7ef6638-3077-4d8a-815f-6885edfe14a2");

            migrationBuilder.DeleteData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "ba4289cb-c761-470f-a1b1-03c4e391ca64");

            migrationBuilder.DeleteData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "c40544f0-a4d0-4cb4-9d83-8ce395496ea3");

            migrationBuilder.DeleteData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "e4e433de-f9bc-4c29-92a8-1e01240cbf12");

            migrationBuilder.DeleteData(
                table: "BusinessSectors",
                keyColumn: "Id",
                keyValue: "e64ba268-3bba-4df1-aabd-3a3af2a2d05c");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "0c9025cc-2085-4deb-9726-4227df85e546");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "14332fcf-925a-45d5-8bfc-dfee96f16855");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "1af41642-cb1f-43b9-b276-06cf1cc9e24f");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "1de07e9a-4549-4ef0-9149-95fcfb8c6db5");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "23e2f177-2bcd-4262-a171-743267a6d3d4");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "287299b2-a882-411d-8f93-52354a1bf3a4");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "28a67009-fb09-4136-bd97-71698faec47a");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "2e7a21c6-2fe4-4c18-8c65-9e0f05423bdd");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "3d7948d7-5d17-45fe-8e93-1f0da83c138d");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "4aa8236c-0a11-484a-8823-45148d7827d5");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "531b275f-7e7d-43ea-ad3f-bea09c346c45");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "54aa93fe-9a3c-49df-83a1-ddd77f60e7cf");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "66998491-8591-4255-86cf-c853ac33a335");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "6e357876-73cd-41a6-9691-89f53bb8f39d");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "6f4960ff-392a-4f50-90f3-7c9169940e6d");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "746a75aa-dcf6-42b5-91a8-47788387ef26");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "7d69cd4a-0b3e-4c41-a801-1cf1012ab13c");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "886533a2-a68f-45de-828c-e3320671facd");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "8ea293be-d587-4a64-b2f6-4eea78a02187");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "9cd53a54-ba51-494d-8167-ab763096af5e");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "a20ff930-cbba-466a-a3ef-acb046e50359");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "b28de821-4eb8-42ad-9caf-5097e9c1ddac");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "b6229a2a-4848-469a-9345-65acb60df6e5");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "be6f0890-2c59-44bf-b334-0032f236242c");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "ce4b8a5d-2c59-44bf-b334-0032f236242c");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "d13134fb-61d6-4ca2-a107-4a0648e4db4f");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "d89fa8a3-6701-4ea6-96b0-5ade9c5ddef9");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "def84e18-144e-4b4a-b900-024d22c389b9");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "e27db493-6614-4e69-ac04-9121b2cbe83b");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "e4e55e4a-f42b-4d38-bf8a-dff81f55e302");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "ead6807b-2852-43c8-aa4d-42caa0fd02ba");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "f8c3366e-dc73-4376-89e6-66980f4fe4ce");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "00a357b8-990e-43ac-99c3-4e7312ce4416");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "0ef9590b-875d-408e-9642-32b6bac23ddf");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "0f4f8a37-859a-4398-9324-6766a3b34d74");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "176bb457-91de-4e1e-ac1c-52b901160225");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2d3f6b89-8158-4c13-a1b2-08efe7a70fa3");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "36f10aef-fed8-4305-939c-27c8905482a4");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "41245942-85e4-41f3-8a25-863bb42d5246");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4868a839-6cdd-4b2e-a1a6-39432c803e14");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "506203f4-c027-484c-b94f-c21c76fb3e97");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "52ab62e2-d2f3-4230-97ed-02891ea8274a");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "71f90e92-d5e6-4b2f-bfda-06dd7106a0ab");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77a016a8-b63e-425f-acae-e0d878f7e35c");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "7afd6f20-897a-4091-b804-3d94eefc8a9b");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "8ed7d069-12d9-4c09-8899-953850e933d4");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "9a361418-0cdb-4068-aaff-253afb9cfdb0");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a1a39d8e-3d38-4390-b285-393aa0d48a85");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a2346728-6d14-4392-af09-4d3ecd917ef3");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a3e67ead-40eb-47a9-ac0c-636fbe9b2aa6");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a4509803-3652-40dd-a425-d9d36ccdad7c");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a8c81edd-ed3d-416a-9ea8-b5943bfca14e");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "a97b23fc-3c0a-451c-aa30-85c36e602293");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "ae8146a2-e35a-43b9-ae53-7c6f04922042");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "b07ad10d-a283-4533-832d-88ddad04e795");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "b0f70a98-f3ca-4265-bd78-d29f39a4175e");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "b7f3d073-c897-4993-b171-837a1d96dc6a");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "bacf7410-b6d4-4558-8422-8cb63d1e1b1c");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "c0556eb8-cc50-45ab-9cf0-d41609c4f8df");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "c509b759-87f4-44e5-8fb2-9abefd16a01d");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "ce846670-cc6c-4d76-8673-4cb778bfaf27");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "cf46e31d-6ba0-4e9a-8db8-e412e8cc06d7");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "d306ed9f-5a1f-42f9-aed0-9c125b26398a");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "d89e1f90-1efc-485b-9bbb-bd5a887beaeb");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "dd5b78a8-5906-441d-b255-effb9deb4b3e");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "e9ea3de4-bc06-4d69-b232-f6e163de65e4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0ca5493b-903d-4863-8194-f1a2925f2088");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "15bbe07e-c6e8-4a82-bedf-4a4303594292");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1f7e704a-d720-49bb-9129-a317cb79756a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "fb0ea19a-7d05-4b0a-9532-59138d1a7bad");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "10ec0309-bda9-41a8-b366-44d3a901f431");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "13ae4b0f-4059-4962-9e34-c9a6fa61b4f3");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "19c0c127-d4b5-4ccc-a9e0-0fd934621aa8");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "2d8a5faf-395e-4c89-aa74-95aa264b8d3d");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "39eaed2a-63d4-47fb-8270-caa5ad8803c9");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "f218305e-4358-4001-87d1-71a63f252bc4");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "f5f8ee19-bf92-4049-a2e5-4ef682b41750");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "325d131a-195e-422d-9e72-2ab306fe5ca7");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "34365695-fcff-454b-8f3e-0b4bcbf63780");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "39baff07-06f8-4702-b313-2e26807d1d1b");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "3c83b90f-1de1-4444-8039-afd777e2f080");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "3d1c4668-07e3-4456-a066-7991e231037d");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "45f38282-072d-49e1-885a-d7420b63ad9a");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "46216ca1-14fb-4361-afb0-8e7cc9ff485b");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "4b1401bf-3619-44df-8191-6516e4b65397");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "56effc3e-cca8-4c9c-adcb-ee69dfebecbd");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "596fc007-022c-4c8f-9633-f8a22f487d66");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "59a370b6-0db0-4f5e-8d2a-d5835b38d242");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "79f1dc3a-50ba-4223-96d1-1ad1f1585904");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "82718aa0-9400-499a-8acc-89ef5b9e9ca2");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "8f836995-92ca-4d16-aef9-940e1a79c2cf");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "9360a076-35ab-4bf7-b267-62b2a79fc0a9");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "93fd0c5d-a66a-4434-b617-e1762caf666b");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "a53b4bd8-ea83-4dc5-b615-dcdf3e9535d6");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "a97032a3-b3ba-4bd8-9927-f27fe70ec36d");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "bf1f59a3-8d4f-42f3-95c1-fc5a26d15e1d");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "e6f007cd-5103-422d-b33c-0a7fa8a1c657");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "eaecb320-e5b9-4396-92e0-4d8c7b4cc7a4");

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: "f06d56e7-b092-4665-948f-b89426ca8d0f");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "7e89aa26-55e6-4056-b34e-9fbcc55898c4");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "dcaec7fd-d140-4ebf-8654-0322c7376766");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "0a794282-ef06-4e94-a567-e3aadcdb4f22");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "12d1fba7-cc1b-4cd0-bd9c-060bad09f79c");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "552500b3-f1fe-4421-a64b-fe1dc3911347");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "55dc334e-4e28-4ce2-bdba-2c0b0429dd39");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "56d332f7-c44c-417a-9655-ade356d09549");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "925a7f89-9d21-411c-800c-5ac7c47b152f");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "a4efc8b0-b662-4745-b414-704ef5081bac");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "ba70f8d4-86be-4b64-a262-159a5c771171");

            migrationBuilder.DeleteData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: "e6209b8b-511c-490e-8ba8-b732eca766b2");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "009fadbc-f3b3-4673-823f-f69783cf8a82");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "3c8aa9c4-22ad-4d85-9fb3-523242a75ec5");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "65e2fb51-ea29-4b79-bb8b-44867608e588");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "961b6103-033e-4290-b64c-f072ebcaa8de");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "16358396-d6d8-4868-a998-72d46370adae");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "172d8827-30b5-46b2-9a45-87b87ede3193");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "6e5c3799-606d-46d3-b191-1da8fdaf38d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "445e48a4-f3f6-4660-96d7-82505bc740d3",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 16, 56, 18, 507, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a993d9d6-0836-40b7-9fd8-a28a7f04a3d0",
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 16, 56, 18, 507, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41dfada5-6c53-4c7b-8c07-89037e511874",
                columns: new[] { "CreatedAt", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 5, 6, 16, 56, 18, 507, DateTimeKind.Local).AddTicks(1847), new DateTime(2024, 5, 6, 16, 56, 18, 507, DateTimeKind.Local).AddTicks(1820) });
        }
    }
}
