using Microsoft.EntityFrameworkCore.Migrations;

namespace Sweaj.Serialization.Api.Migrations
{
    public partial class change_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateUploaded",
                table: "VideoMetadatas",
                newName: "UploadDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UploadDate",
                table: "VideoMetadatas",
                newName: "DateUploaded");
        }
    }
}
