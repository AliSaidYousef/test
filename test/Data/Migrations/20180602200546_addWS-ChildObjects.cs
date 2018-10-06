using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace test.Data.Migrations
{
    public partial class addWSChildObjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WSDetailViews",
                columns: table => new
                {
                    WSDetailViewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WSDVSerialNumber = table.Column<int>(nullable: false),
                    WSDVWorkStepID = table.Column<int>(nullable: false),
                    WSDetailViewName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WSDetailViews", x => x.WSDetailViewID);
                    table.ForeignKey(
                        name: "FK_WSDetailViews_WorkSteps_WSDVWorkStepID",
                        column: x => x.WSDVWorkStepID,
                        principalTable: "WorkSteps",
                        principalColumn: "WorkStepID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WSHeaderObjects",
                columns: table => new
                {
                    WSHeaderObjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WSHHOSerialNumber = table.Column<int>(nullable: false),
                    WSHOWorkStepID = table.Column<int>(nullable: false),
                    WSHObjectName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WSHeaderObjects", x => x.WSHeaderObjectID);
                    table.ForeignKey(
                        name: "FK_WSHeaderObjects_WorkSteps_WSHOWorkStepID",
                        column: x => x.WSHOWorkStepID,
                        principalTable: "WorkSteps",
                        principalColumn: "WorkStepID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GetWSDVDetailObjects",
                columns: table => new
                {
                    WSDVDetailObjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DVDOAllowNull = table.Column<bool>(nullable: false),
                    DVDOCalculationFormula = table.Column<string>(nullable: true),
                    DVDOControlType = table.Column<string>(nullable: true),
                    DVDODataType = table.Column<string>(nullable: true),
                    DVDODefaultValue = table.Column<string>(nullable: true),
                    DVDODetailViewID = table.Column<int>(nullable: false),
                    DVDOExecutionIdentifier = table.Column<bool>(nullable: false),
                    DVDOIsActive = table.Column<bool>(nullable: false),
                    DVDOIsCalculated = table.Column<bool>(nullable: false),
                    DVDOIsEditingByUserAllowed = table.Column<bool>(nullable: false),
                    DVDOIsUnique = table.Column<bool>(nullable: false),
                    DVDOName = table.Column<string>(nullable: true),
                    DVDOSerialNumber = table.Column<int>(nullable: false),
                    DVDOTabOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetWSDVDetailObjects", x => x.WSDVDetailObjectID);
                    table.ForeignKey(
                        name: "FK_GetWSDVDetailObjects_WSDetailViews_DVDODetailViewID",
                        column: x => x.DVDODetailViewID,
                        principalTable: "WSDetailViews",
                        principalColumn: "WSDetailViewID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GetWSDVDetailObjects_DVDODetailViewID",
                table: "GetWSDVDetailObjects",
                column: "DVDODetailViewID");

            migrationBuilder.CreateIndex(
                name: "IX_WSDetailViews_WSDVWorkStepID",
                table: "WSDetailViews",
                column: "WSDVWorkStepID");

            migrationBuilder.CreateIndex(
                name: "IX_WSHeaderObjects_WSHOWorkStepID",
                table: "WSHeaderObjects",
                column: "WSHOWorkStepID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetWSDVDetailObjects");

            migrationBuilder.DropTable(
                name: "WSHeaderObjects");

            migrationBuilder.DropTable(
                name: "WSDetailViews");
        }
    }
}
