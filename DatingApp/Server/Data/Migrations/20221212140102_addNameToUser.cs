using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.Server.Data.Migrations
{
    public partial class addNameToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "ICNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");
            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");
            migrationBuilder.DropColumn(
                name: "ICNumber",
                table: "AspNetUsers");
        }
    }
}
