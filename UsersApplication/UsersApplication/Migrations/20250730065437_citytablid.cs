using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersApplication.Migrations
{
    /// <inheritdoc />
    public partial class citytablid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Courses",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Courses",
                newName: "MyProperty");
        }
    }
}
