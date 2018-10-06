using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace test.Data.Migrations
{
    public partial class add_IsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "wSDVIsActive",
                table: "WSDetailViews",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WorkStepIsActive",
                table: "WorkSteps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProcessIsActive",
                table: "Processes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InstitutionIsActive",
                table: "Institutions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DepartmentIsActive",
                table: "Departments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ApprovalStep",
                columns: table => new
                {
                    ApprovalStepID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApprovalStepIsActive = table.Column<bool>(nullable: false),
                    ApprovalStepName = table.Column<string>(nullable: true),
                    WorkStepID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalStep", x => x.ApprovalStepID);
                    table.ForeignKey(
                        name: "FK_ApprovalStep_WorkSteps_WorkStepID",
                        column: x => x.WorkStepID,
                        principalTable: "WorkSteps",
                        principalColumn: "WorkStepID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalStep_WorkStepID",
                table: "ApprovalStep",
                column: "WorkStepID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApprovalStep");

            migrationBuilder.DropColumn(
                name: "wSDVIsActive",
                table: "WSDetailViews");

            migrationBuilder.DropColumn(
                name: "WorkStepIsActive",
                table: "WorkSteps");

            migrationBuilder.DropColumn(
                name: "ProcessIsActive",
                table: "Processes");

            migrationBuilder.DropColumn(
                name: "InstitutionIsActive",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "DepartmentIsActive",
                table: "Departments");
        }
    }
}
