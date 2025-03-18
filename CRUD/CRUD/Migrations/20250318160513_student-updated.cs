using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD.Migrations
{
    /// <inheritdoc />
    public partial class studentupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "batch",
                table: "tbl_Students");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "tbl_Students",
                newName: "semail");

            migrationBuilder.AddColumn<string>(
                name: "sbatch",
                table: "tbl_Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sbatch",
                table: "tbl_Students");

            migrationBuilder.RenameColumn(
                name: "semail",
                table: "tbl_Students",
                newName: "email");

            migrationBuilder.AddColumn<int>(
                name: "batch",
                table: "tbl_Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
