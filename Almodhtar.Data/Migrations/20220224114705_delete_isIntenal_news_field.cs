using Microsoft.EntityFrameworkCore.Migrations;

namespace Almodhtar.Data.Migrations
{
    public partial class delete_isIntenal_news_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInternal",
                table: "News");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInternal",
                table: "News",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
