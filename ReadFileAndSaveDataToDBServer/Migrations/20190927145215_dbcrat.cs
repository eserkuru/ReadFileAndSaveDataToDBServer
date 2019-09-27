using Microsoft.EntityFrameworkCore.Migrations;

namespace ReadFileAndSaveDataToDBServer.Migrations
{
    public partial class dbcrat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ballcocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BallcockNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ballcocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adcps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BallcockId = table.Column<int>(nullable: false),
                    ProfileNo = table.Column<int>(nullable: false),
                    DateTime = table.Column<string>(nullable: true),
                    VDT = table.Column<string>(nullable: true),
                    V1 = table.Column<decimal>(nullable: false),
                    V2 = table.Column<decimal>(nullable: false),
                    V3 = table.Column<decimal>(nullable: false),
                    V4 = table.Column<decimal>(nullable: false),
                    V5 = table.Column<decimal>(nullable: false),
                    V6 = table.Column<decimal>(nullable: false),
                    V7 = table.Column<decimal>(nullable: false),
                    V8 = table.Column<decimal>(nullable: false),
                    V9 = table.Column<decimal>(nullable: false),
                    V10 = table.Column<decimal>(nullable: false),
                    V11 = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adcps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adcps_Ballcocks_BallcockId",
                        column: x => x.BallcockId,
                        principalTable: "Ballcocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdcpDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AdcpId = table.Column<int>(nullable: false),
                    V1 = table.Column<int>(nullable: false),
                    V2 = table.Column<int>(nullable: false),
                    V3 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdcpDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdcpDetails_Adcps_AdcpId",
                        column: x => x.AdcpId,
                        principalTable: "Adcps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdcpDetails_AdcpId",
                table: "AdcpDetails",
                column: "AdcpId");

            migrationBuilder.CreateIndex(
                name: "IX_Adcps_BallcockId",
                table: "Adcps",
                column: "BallcockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdcpDetails");

            migrationBuilder.DropTable(
                name: "Adcps");

            migrationBuilder.DropTable(
                name: "Ballcocks");
        }
    }
}
