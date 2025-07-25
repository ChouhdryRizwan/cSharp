using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersApplication.Migrations
{
    /// <inheritdoc />
    public partial class addimagecolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentImage",
                table: "Students",
                type: "varchar(250)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentImage",
                table: "Students");
        }
    }
}
