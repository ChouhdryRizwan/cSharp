using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersApplication.Migrations
{
    /// <inheritdoc />
    public partial class createStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "varchar(120)", nullable: false),
                    StudentEmail = table.Column<string>(type: "varchar(50)", nullable: false),
                    Mobile = table.Column<string>(type: "varchar(50)", nullable: false),
                    StudentAddress = table.Column<string>(type: "varchar(250)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
