﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidasDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changeNullablePhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "varchar(15)",
                unicode: false,
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldUnicode: false,
                oldMaxLength: 15);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "varchar(15)",
                unicode: false,
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldUnicode: false,
                oldMaxLength: 15,
                oldNullable: true);
        }
    }
}
