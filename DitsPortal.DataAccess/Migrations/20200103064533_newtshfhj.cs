using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DitsPortal.DataAccess.Migrations
{
    public partial class newtshfhj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leave");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leave",
                columns: table => new
                {
                    LeaveId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AppliedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "Datetime", nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "Datetime", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    FromSession = table.Column<string>(type: "varchar(255)", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LeaveType = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "Datetime", nullable: true),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    PendingLeaves = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "varchar(255)", nullable: true),
                    RejectedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    RejectionReason = table.Column<string>(type: "varchar(255)", nullable: true),
                    RequestStatus = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    ToSession = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave", x => x.LeaveId);
                });
        }
    }
}
