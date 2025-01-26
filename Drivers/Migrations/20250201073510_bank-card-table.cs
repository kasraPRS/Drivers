using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drivers.Migrations
{
    /// <inheritdoc />
    public partial class bankcardtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankCardServiceModel_Profiles_UserId",
                table: "BankCardServiceModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankCardServiceModel",
                table: "BankCardServiceModel");

            migrationBuilder.RenameTable(
                name: "BankCardServiceModel",
                newName: "BankCards");

            migrationBuilder.RenameIndex(
                name: "IX_BankCardServiceModel_UserId",
                table: "BankCards",
                newName: "IX_BankCards_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BankCardServiceModel_BankCardNumber",
                table: "BankCards",
                newName: "IX_BankCards_BankCardNumber");

            migrationBuilder.RenameIndex(
                name: "IX_BankCardServiceModel_AccountNumber",
                table: "BankCards",
                newName: "IX_BankCards_AccountNumber");

            migrationBuilder.AlterColumn<int>(
                name: "BankCardNumber",
                table: "BankCards",
                type: "int",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "BankCards",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "CVV2",
                table: "BankCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpairedDate",
                table: "BankCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankCards",
                table: "BankCards",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankCards_Profiles_UserId",
                table: "BankCards",
                column: "UserId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankCards_Profiles_UserId",
                table: "BankCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankCards",
                table: "BankCards");

            migrationBuilder.DropColumn(
                name: "CVV2",
                table: "BankCards");

            migrationBuilder.DropColumn(
                name: "ExpairedDate",
                table: "BankCards");

            migrationBuilder.RenameTable(
                name: "BankCards",
                newName: "BankCardServiceModel");

            migrationBuilder.RenameIndex(
                name: "IX_BankCards_UserId",
                table: "BankCardServiceModel",
                newName: "IX_BankCardServiceModel_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BankCards_BankCardNumber",
                table: "BankCardServiceModel",
                newName: "IX_BankCardServiceModel_BankCardNumber");

            migrationBuilder.RenameIndex(
                name: "IX_BankCards_AccountNumber",
                table: "BankCardServiceModel",
                newName: "IX_BankCardServiceModel_AccountNumber");

            migrationBuilder.AlterColumn<string>(
                name: "BankCardNumber",
                table: "BankCardServiceModel",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "BankCardServiceModel",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankCardServiceModel",
                table: "BankCardServiceModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankCardServiceModel_Profiles_UserId",
                table: "BankCardServiceModel",
                column: "UserId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
