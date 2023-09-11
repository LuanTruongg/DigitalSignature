using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalSignature.Data.Migrations
{
    public partial class Add_change_FK_User_Department : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppUsers_DepartmentId",
                table: "AppUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_DepartmentId",
                table: "AppUsers",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppUsers_DepartmentId",
                table: "AppUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_DepartmentId",
                table: "AppUsers",
                column: "DepartmentId",
                unique: true);
        }
    }
}
