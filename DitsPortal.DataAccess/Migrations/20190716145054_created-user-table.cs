using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DitsPortal.DataAccess.Migrations
{
    public partial class createdusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "Datetime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "Datetime", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "Datetime", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "Datetime", nullable: true),
                    Email = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    Password = table.Column<string>(type: "varchar(255)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Designation = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    AlternateNumber = table.Column<string>(nullable: true),
                    OfficialEmail = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    ResetToken = table.Column<string>(nullable: true),
                    PAN = table.Column<string>(nullable: true),
                    BloodGroup = table.Column<int>(nullable: true),
                    DateOfJoining = table.Column<DateTime>(nullable: true),
                    DateOfLeaving = table.Column<DateTime>(nullable: true),
                    MediaId = table.Column<int>(nullable: true),
                    LastLoggedIn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
