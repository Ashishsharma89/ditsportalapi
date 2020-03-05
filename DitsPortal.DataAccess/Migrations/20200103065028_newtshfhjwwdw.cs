using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DitsPortal.DataAccess.Migrations
{
    public partial class newtshfhjwwdw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leave",
                columns: table => new
                {
                    LeaveId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "Datetime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "Datetime", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "Datetime", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    LeaveType = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    PendingLeaves = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "varchar(255)", nullable: true),
                    AppliedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    RequestStatus = table.Column<int>(type: "int", nullable: false),
                    RejectionDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    RejectionReason = table.Column<string>(type: "varchar(255)", nullable: true),
                    RejectedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    FromSession = table.Column<string>(type: "varchar(255)", nullable: true),
                    ToSession = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave", x => x.LeaveId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leave");
        }
    }
}
