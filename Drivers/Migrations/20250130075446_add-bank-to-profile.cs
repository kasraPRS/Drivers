using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drivers.Migrations
{
    /// <inheritdoc />
    public partial class addbanktoprofile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankCardServiceModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankCardNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankCardServiceModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankCardServiceModel_Profiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankCardServiceModel_AccountNumber",
                table: "BankCardServiceModel",
                column: "AccountNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankCardServiceModel_BankCardNumber",
                table: "BankCardServiceModel",
                column: "BankCardNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankCardServiceModel_UserProfileId",
                table: "BankCardServiceModel",
                column: "UserProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankCardServiceModel");
        }
    }
}
