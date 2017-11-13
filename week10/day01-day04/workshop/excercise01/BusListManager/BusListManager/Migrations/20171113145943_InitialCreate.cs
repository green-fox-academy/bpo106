using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BusListManager.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "List",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comments = table.Column<string>(nullable: true),
                    DateOfGet = table.Column<DateTime>(nullable: false),
                    DateOfWithdrawal = table.Column<DateTime>(nullable: false),
                    Depot = table.Column<string>(nullable: true),
                    FormerLicensePlate = table.Column<string>(nullable: true),
                    FormerNumber = table.Column<int>(nullable: false),
                    IsInOperation = table.Column<bool>(nullable: false),
                    Kilometer = table.Column<int>(nullable: false),
                    LicensePlate = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "List");
        }
    }
}
