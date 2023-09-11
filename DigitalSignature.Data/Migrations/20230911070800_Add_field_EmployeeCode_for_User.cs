using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalSignature.Data.Migrations
{
    public partial class Add_field_EmployeeCode_for_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeCode",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeCode",
                table: "AppUsers");
        }
    }
}
