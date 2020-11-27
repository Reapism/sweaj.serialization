using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sweaj.Serialization.Api.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoMetadatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaylistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAgeRestricted = table.Column<bool>(type: "bit", nullable: false),
                    IsForKids = table.Column<bool>(type: "bit", nullable: false),
                    IsMonetized = table.Column<bool>(type: "bit", nullable: false),
                    IsCommentsAllowed = table.Column<bool>(type: "bit", nullable: false),
                    AllowEmbedding = table.Column<bool>(type: "bit", nullable: false),
                    Thumbnail = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ViewCount = table.Column<long>(type: "bigint", nullable: false),
                    RecordingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUploaded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoMetadatas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoMetadatas");
        }
    }
}
