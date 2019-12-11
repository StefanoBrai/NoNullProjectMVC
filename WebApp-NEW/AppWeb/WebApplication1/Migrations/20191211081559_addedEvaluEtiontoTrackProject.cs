using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class addedEvaluEtiontoTrackProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompEvaluetion",
                schema: "NoNull",
                table: "TrackRequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfEValuation",
                schema: "NoNull",
                table: "TrackRequests",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompEvaluetion",
                schema: "NoNull",
                table: "TrackRequests");

            migrationBuilder.DropColumn(
                name: "ProfEValuation",
                schema: "NoNull",
                table: "TrackRequests");
        }
    }
}
