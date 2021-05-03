using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CastColumnUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TowFactorEnabled",
                table: "User",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "LastLodinDateTime",
                table: "User",
                newName: "LastLoginDateTime");

            migrationBuilder.RenameColumn(
                name: "AccessFaildCount",
                table: "User",
                newName: "AccessFailedCount");

            migrationBuilder.RenameColumn(
                name: "TmbdUrl",
                table: "Cast",
                newName: "TmdbUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "User",
                newName: "TowFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "LastLoginDateTime",
                table: "User",
                newName: "LastLodinDateTime");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "User",
                newName: "AccessFaildCount");

            migrationBuilder.RenameColumn(
                name: "TmdbUrl",
                table: "Cast",
                newName: "TmbdUrl");
        }
    }
}
