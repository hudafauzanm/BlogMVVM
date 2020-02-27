using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Data.Migrations
{
    public partial class add_attribute_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "comment_name",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "author",
                table: "Articles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "comment_name",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "author",
                table: "Articles");
        }
    }
}
