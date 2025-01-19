using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_MVC.Migrations
{
    /// <inheritdoc />
    public partial class changetablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "StudentsRecords");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentsRecords",
                table: "StudentsRecords",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentsRecords",
                table: "StudentsRecords");

            migrationBuilder.RenameTable(
                name: "StudentsRecords",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");
        }
    }
}
