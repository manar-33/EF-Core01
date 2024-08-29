using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core01.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "MyDepartments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyDepartments",
                table: "MyDepartments",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyDepartments",
                table: "MyDepartments");

            migrationBuilder.RenameTable(
                name: "MyDepartments",
                newName: "Departments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");
        }
    }
}
