using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_example.Migrations
{
    /// <inheritdoc />
    public partial class addreadtimes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "read_times",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "read_times",
                table: "Post");
        }
    }
}
