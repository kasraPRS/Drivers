using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drivers.Migrations
{
    /// <inheritdoc />
    public partial class userprofileforionkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankCardServiceModel_Profiles_UserProfileId",
                table: "BankCardServiceModel");

            migrationBuilder.DropIndex(
                name: "IX_BankCardServiceModel_UserProfileId",
                table: "BankCardServiceModel");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "BankCardServiceModel");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "BankCardServiceModel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_BankCardServiceModel_UserId",
                table: "BankCardServiceModel",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankCardServiceModel_Profiles_UserId",
                table: "BankCardServiceModel",
                column: "UserId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankCardServiceModel_Profiles_UserId",
                table: "BankCardServiceModel");

            migrationBuilder.DropIndex(
                name: "IX_BankCardServiceModel_UserId",
                table: "BankCardServiceModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BankCardServiceModel");

            migrationBuilder.AddColumn<Guid>(
                name: "UserProfileId",
                table: "BankCardServiceModel",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankCardServiceModel_UserProfileId",
                table: "BankCardServiceModel",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankCardServiceModel_Profiles_UserProfileId",
                table: "BankCardServiceModel",
                column: "UserProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");
        }
    }
}
