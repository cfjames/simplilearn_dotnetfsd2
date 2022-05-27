using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Phase2Section2._18.Migrations
{
    public partial class AddParentName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ParentName",
                table: "Student",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentName",
                table: "Student");
        }
    }
}
