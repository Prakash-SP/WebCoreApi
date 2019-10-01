using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace coreWebApiTest.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(nullable: false),
                    isdelete = table.Column<bool>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdOn = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<Guid>(nullable: false),
                    updatedOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<Guid>(nullable: false),
                    deletedOn = table.Column<DateTime>(nullable: false),
                    deleteBy = table.Column<Guid>(nullable: false),
                    activatedOn = table.Column<DateTime>(nullable: false),
                    activatedBy = table.Column<DateTime>(nullable: false),
                    deactivatedOn = table.Column<DateTime>(nullable: false),
                    deactivatedBy = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    OfficeId = table.Column<Guid>(nullable: false),
                    isdelete = table.Column<bool>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdOn = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<Guid>(nullable: false),
                    updatedOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<Guid>(nullable: false),
                    deletedOn = table.Column<DateTime>(nullable: false),
                    deleteBy = table.Column<Guid>(nullable: false),
                    activatedOn = table.Column<DateTime>(nullable: false),
                    activatedBy = table.Column<DateTime>(nullable: false),
                    deactivatedOn = table.Column<DateTime>(nullable: false),
                    deactivatedBy = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CompanyId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.OfficeId);
                    table.ForeignKey(
                        name: "FK_Offices_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobDes",
                columns: table => new
                {
                    JobDesId = table.Column<Guid>(nullable: false),
                    isdelete = table.Column<bool>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdOn = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<Guid>(nullable: false),
                    updatedOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<Guid>(nullable: false),
                    deletedOn = table.Column<DateTime>(nullable: false),
                    deleteBy = table.Column<Guid>(nullable: false),
                    activatedOn = table.Column<DateTime>(nullable: false),
                    activatedBy = table.Column<DateTime>(nullable: false),
                    deactivatedOn = table.Column<DateTime>(nullable: false),
                    deactivatedBy = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    OfficeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDes", x => x.JobDesId);
                    table.ForeignKey(
                        name: "FK_JobDes_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(nullable: false),
                    isdelete = table.Column<bool>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdOn = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<Guid>(nullable: false),
                    updatedOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<Guid>(nullable: false),
                    deletedOn = table.Column<DateTime>(nullable: false),
                    deleteBy = table.Column<Guid>(nullable: false),
                    activatedOn = table.Column<DateTime>(nullable: false),
                    activatedBy = table.Column<DateTime>(nullable: false),
                    deactivatedOn = table.Column<DateTime>(nullable: false),
                    deactivatedBy = table.Column<DateTime>(nullable: false),
                    JobDesId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    MobileNo = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_JobDes_JobDesId",
                        column: x => x.JobDesId,
                        principalTable: "JobDes",
                        principalColumn: "JobDesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobDesId",
                table: "Employees",
                column: "JobDesId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDes_OfficeId",
                table: "JobDes",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_CompanyId",
                table: "Offices",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "JobDes");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
