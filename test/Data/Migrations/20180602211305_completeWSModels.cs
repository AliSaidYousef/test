using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace test.Data.Migrations
{
    public partial class completeWSModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "wSHOAllowNull",
                table: "WSHeaderObjects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "wSHOCalculationFormula",
                table: "WSHeaderObjects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "wSHOControlType",
                table: "WSHeaderObjects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "wSHODataType",
                table: "WSHeaderObjects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "wSHODefaultValue",
                table: "WSHeaderObjects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "wSHOExecutionIdentifier",
                table: "WSHeaderObjects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "wSHOIsActive",
                table: "WSHeaderObjects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "wSHOIsCalculated",
                table: "WSHeaderObjects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "wSHOIsEditingByUserAllowed",
                table: "WSHeaderObjects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "wSHOIsUnique",
                table: "WSHeaderObjects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "wSHOTabOrder",
                table: "WSHeaderObjects",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "wSHOAllowNull",
                table: "WSHeaderObjects");

            migrationBuilder.DropColumn(
                name: "wSHOCalculationFormula",
                table: "WSHeaderObjects");

            migrationBuilder.DropColumn(
                name: "wSHOControlType",
                table: "WSHeaderObjects");

            migrationBuilder.DropColumn(
                name: "wSHODataType",
                table: "WSHeaderObjects");

            migrationBuilder.DropColumn(
                name: "wSHODefaultValue",
                table: "WSHeaderObjects");

            migrationBuilder.DropColumn(
                name: "wSHOExecutionIdentifier",
                table: "WSHeaderObjects");

            migrationBuilder.DropColumn(
                name: "wSHOIsActive",
                table: "WSHeaderObjects");

            migrationBuilder.DropColumn(
                name: "wSHOIsCalculated",
                table: "WSHeaderObjects");

            migrationBuilder.DropColumn(
                name: "wSHOIsEditingByUserAllowed",
                table: "WSHeaderObjects");

            migrationBuilder.DropColumn(
                name: "wSHOIsUnique",
                table: "WSHeaderObjects");

            migrationBuilder.DropColumn(
                name: "wSHOTabOrder",
                table: "WSHeaderObjects");
        }
    }
}
