using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstRedone.Migrations
{
    public partial class addedGPA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "GPA",
                table: "Students",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GPA",
                table: "Students");
        }
    }
}
