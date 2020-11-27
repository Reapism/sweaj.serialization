using Microsoft.EntityFrameworkCore.Migrations;

namespace Sweaj.Serialization.Api.Migrations
{
    public partial class Add_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageSeed",
                table: "VideoMetadatas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageSeed",
                table: "VideoMetadatas");
        }
    }
}
