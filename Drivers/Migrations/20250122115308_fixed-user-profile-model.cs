using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drivers.Migrations
{
    /// <inheritdoc />
    public partial class fixeduserprofilemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "UserProfiles",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "UserProfiles",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_Phone",
                table: "UserProfiles",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_PublicId",
                table: "UserProfiles",
                column: "PublicId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserProfiles_Phone",
                table: "UserProfiles");

            migrationBuilder.DropIndex(
                name: "IX_UserProfiles_PublicId",
                table: "UserProfiles");

            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
