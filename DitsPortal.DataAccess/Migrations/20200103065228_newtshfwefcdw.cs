using Microsoft.EntityFrameworkCore.Migrations;

namespace DitsPortal.DataAccess.Migrations
{
    public partial class newtshfwefcdw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "NumberOfDays",
                table: "Leave",
                type: "Double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumberOfDays",
                table: "Leave",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "Double");
        }
    }
}
