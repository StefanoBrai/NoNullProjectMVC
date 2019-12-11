using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.EnsureSchema(
            //    name: "NoNull");

            //migrationBuilder.CreateTable(
            //    name: "Destinations",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        destinationid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(maxLength: 20, nullable: false),
            //        macroarea = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Destinations", x => x.destinationid);
            //        table.ForeignKey(
            //            name: "FK_Dest_Dest",
            //            column: x => x.macroarea,
            //            principalSchema: "NoNull",
            //            principalTable: "Destinations",
            //            principalColumn: "destinationid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GeneralArea",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        generalareaid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GeneralArea", x => x.generalareaid);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Professionists",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        profid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        lastname = table.Column<string>(maxLength: 20, nullable: false),
            //        firstname = table.Column<string>(maxLength: 10, nullable: false),
            //        profession = table.Column<string>(maxLength: 60, nullable: false),
            //        birthdate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        address = table.Column<string>(maxLength: 60, nullable: false),
            //        city = table.Column<string>(maxLength: 15, nullable: false),
            //        region = table.Column<string>(maxLength: 15, nullable: true),
            //        postalcode = table.Column<string>(maxLength: 10, nullable: true),
            //        destinationid = table.Column<int>(nullable: false),
            //        phone = table.Column<string>(maxLength: 24, nullable: false),
            //        mail = table.Column<string>(maxLength: 40, nullable: false),
            //        minavailability = table.Column<string>(maxLength: 20, nullable: false),
            //        maxavailability = table.Column<string>(maxLength: 40, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Professionists", x => x.profid);
            //        table.ForeignKey(
            //            name: "FK_Prof_Destinations",
            //            column: x => x.destinationid,
            //            principalSchema: "NoNull",
            //            principalTable: "Destinations",
            //            principalColumn: "destinationid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Companies",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        compid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(maxLength: 80, nullable: false),
            //        type = table.Column<string>(maxLength: 20, nullable: false),
            //        address = table.Column<string>(maxLength: 60, nullable: false),
            //        city = table.Column<string>(maxLength: 15, nullable: false),
            //        region = table.Column<string>(maxLength: 15, nullable: true),
            //        postalcode = table.Column<string>(maxLength: 10, nullable: true),
            //        destinationid = table.Column<int>(nullable: false),
            //        generalareaid = table.Column<int>(nullable: false),
            //        mission = table.Column<string>(maxLength: 120, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Companies", x => x.compid);
            //        table.ForeignKey(
            //            name: "FK_Company_Destinations",
            //            column: x => x.destinationid,
            //            principalSchema: "NoNull",
            //            principalTable: "Destinations",
            //            principalColumn: "destinationid",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Company_GeneralArea",
            //            column: x => x.generalareaid,
            //            principalSchema: "NoNull",
            //            principalTable: "GeneralArea",
            //            principalColumn: "generalareaid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Availabilities",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        avaid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        profid = table.Column<int>(nullable: false),
            //        beginningdate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        endingdate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        destinationid = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Availabilities", x => x.avaid);
            //        table.ForeignKey(
            //            name: "FK_Availabilities_Destinations",
            //            column: x => x.destinationid,
            //            principalSchema: "NoNull",
            //            principalTable: "Destinations",
            //            principalColumn: "destinationid",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Ava_Prof",
            //            column: x => x.profid,
            //            principalSchema: "NoNull",
            //            principalTable: "Professionists",
            //            principalColumn: "profid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Skills",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        skillid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        generalareaid = table.Column<int>(nullable: false),
            //        profid = table.Column<int>(nullable: false),
            //        level = table.Column<int>(nullable: false),
            //        description = table.Column<string>(maxLength: 120, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Skills", x => x.skillid);
            //        table.ForeignKey(
            //            name: "FK_Skills_GeneralArea",
            //            column: x => x.generalareaid,
            //            principalSchema: "NoNull",
            //            principalTable: "GeneralArea",
            //            principalColumn: "generalareaid",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Skills_Profs",
            //            column: x => x.profid,
            //            principalSchema: "NoNull",
            //            principalTable: "Professionists",
            //            principalColumn: "profid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CompanyReference",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        refid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        compid = table.Column<int>(nullable: false),
            //        lastname = table.Column<string>(maxLength: 20, nullable: false),
            //        firstname = table.Column<string>(maxLength: 10, nullable: false),
            //        birthdate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        phone = table.Column<string>(maxLength: 24, nullable: false),
            //        mail = table.Column<string>(maxLength: 40, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CompanyReference", x => x.refid);
            //        table.ForeignKey(
            //            name: "FK_Ref_Comp",
            //            column: x => x.compid,
            //            principalSchema: "NoNull",
            //            principalTable: "Companies",
            //            principalColumn: "compid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Projects",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        projid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        generalareaid = table.Column<int>(nullable: false),
            //        compid = table.Column<int>(nullable: false),
            //        description = table.Column<string>(maxLength: 120, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Projects", x => x.projid);
            //        table.ForeignKey(
            //            name: "FK_Proj_Comp",
            //            column: x => x.compid,
            //            principalSchema: "NoNull",
            //            principalTable: "Companies",
            //            principalColumn: "compid",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Proj_GeneralArea",
            //            column: x => x.generalareaid,
            //            principalSchema: "NoNull",
            //            principalTable: "GeneralArea",
            //            principalColumn: "generalareaid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Requests",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        reqid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        compid = table.Column<int>(nullable: false),
            //        projid = table.Column<int>(nullable: false),
            //        skillid = table.Column<int>(nullable: false),
            //        destinationid = table.Column<int>(nullable: false),
            //        beginningdate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        endingdate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        description = table.Column<string>(maxLength: 120, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_REqeusts", x => x.reqid);
            //        table.ForeignKey(
            //            name: "FK_Req_Comp",
            //            column: x => x.compid,
            //            principalSchema: "NoNull",
            //            principalTable: "Companies",
            //            principalColumn: "compid",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Req_Destinations",
            //            column: x => x.destinationid,
            //            principalSchema: "NoNull",
            //            principalTable: "Destinations",
            //            principalColumn: "destinationid",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Req_Proj",
            //            column: x => x.projid,
            //            principalSchema: "NoNull",
            //            principalTable: "Projects",
            //            principalColumn: "projid",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Req_Skill",
            //            column: x => x.skillid,
            //            principalSchema: "NoNull",
            //            principalTable: "Skills",
            //            principalColumn: "skillid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Bid",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        bidid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        profid = table.Column<int>(nullable: false),
            //        reqid = table.Column<int>(nullable: false),
            //        acceptation = table.Column<bool>(nullable: false),
            //        senddata = table.Column<DateTime>(type: "datetime", nullable: false),
            //        message = table.Column<string>(maxLength: 120, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Bid", x => x.bidid);
            //        table.ForeignKey(
            //            name: "FK_Bid_Prof",
            //            column: x => x.profid,
            //            principalSchema: "NoNull",
            //            principalTable: "Professionists",
            //            principalColumn: "profid",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Bid_Req",
            //            column: x => x.reqid,
            //            principalSchema: "NoNull",
            //            principalTable: "Requests",
            //            principalColumn: "reqid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Candidature",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        candidatureid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        profid = table.Column<int>(nullable: false),
            //        reqid = table.Column<int>(nullable: false),
            //        acceptation = table.Column<bool>(nullable: false),
            //        senddata = table.Column<DateTime>(type: "datetime", nullable: false),
            //        message = table.Column<string>(maxLength: 120, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Candidature", x => x.candidatureid);
            //        table.ForeignKey(
            //            name: "FK_Candidature_Prof",
            //            column: x => x.profid,
            //            principalSchema: "NoNull",
            //            principalTable: "Professionists",
            //            principalColumn: "profid",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Candidature_Req",
            //            column: x => x.reqid,
            //            principalSchema: "NoNull",
            //            principalTable: "Requests",
            //            principalColumn: "reqid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TrackRequests",
            //    schema: "NoNull",
            //    columns: table => new
            //    {
            //        trackid = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        profid = table.Column<int>(nullable: false),
            //        reqid = table.Column<int>(nullable: false),
            //        beginningdate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        endingdate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        profcomment = table.Column<string>(maxLength: 120, nullable: true),
            //        compcomment = table.Column<string>(maxLength: 120, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TrackRequests", x => x.trackid);
            //        table.ForeignKey(
            //            name: "FK_Track_Prof",
            //            column: x => x.profid,
            //            principalSchema: "NoNull",
            //            principalTable: "Professionists",
            //            principalColumn: "profid",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Track_Req",
            //            column: x => x.reqid,
            //            principalSchema: "NoNull",
            //            principalTable: "Requests",
            //            principalColumn: "reqid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Availabilities_destinationid",
            //    schema: "NoNull",
            //    table: "Availabilities",
            //    column: "destinationid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Availabilities_profid",
            //    schema: "NoNull",
            //    table: "Availabilities",
            //    column: "profid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Bid_profid",
            //    schema: "NoNull",
            //    table: "Bid",
            //    column: "profid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Bid_reqid",
            //    schema: "NoNull",
            //    table: "Bid",
            //    column: "reqid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Candidature_profid",
            //    schema: "NoNull",
            //    table: "Candidature",
            //    column: "profid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Candidature_reqid",
            //    schema: "NoNull",
            //    table: "Candidature",
            //    column: "reqid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Companies_destinationid",
            //    schema: "NoNull",
            //    table: "Companies",
            //    column: "destinationid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Companies_generalareaid",
            //    schema: "NoNull",
            //    table: "Companies",
            //    column: "generalareaid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CompanyReference_compid",
            //    schema: "NoNull",
            //    table: "CompanyReference",
            //    column: "compid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Destinations_macroarea",
            //    schema: "NoNull",
            //    table: "Destinations",
            //    column: "macroarea");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Professionists_destinationid",
            //    schema: "NoNull",
            //    table: "Professionists",
            //    column: "destinationid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Projects_compid",
            //    schema: "NoNull",
            //    table: "Projects",
            //    column: "compid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Projects_generalareaid",
            //    schema: "NoNull",
            //    table: "Projects",
            //    column: "generalareaid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Requests_compid",
            //    schema: "NoNull",
            //    table: "Requests",
            //    column: "compid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Requests_destinationid",
            //    schema: "NoNull",
            //    table: "Requests",
            //    column: "destinationid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Requests_projid",
            //    schema: "NoNull",
            //    table: "Requests",
            //    column: "projid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Requests_skillid",
            //    schema: "NoNull",
            //    table: "Requests",
            //    column: "skillid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Skills_generalareaid",
            //    schema: "NoNull",
            //    table: "Skills",
            //    column: "generalareaid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Skills_profid",
            //    schema: "NoNull",
            //    table: "Skills",
            //    column: "profid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TrackRequests_profid",
            //    schema: "NoNull",
            //    table: "TrackRequests",
            //    column: "profid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TrackRequests_reqid",
            //    schema: "NoNull",
            //    table: "TrackRequests",
            //    column: "reqid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Availabilities",
                schema: "NoNull");

            migrationBuilder.DropTable(
                name: "Bid",
                schema: "NoNull");

            migrationBuilder.DropTable(
                name: "Candidature",
                schema: "NoNull");

            migrationBuilder.DropTable(
                name: "CompanyReference",
                schema: "NoNull");

            migrationBuilder.DropTable(
                name: "TrackRequests",
                schema: "NoNull");

            migrationBuilder.DropTable(
                name: "Requests",
                schema: "NoNull");

            migrationBuilder.DropTable(
                name: "Projects",
                schema: "NoNull");

            migrationBuilder.DropTable(
                name: "Skills",
                schema: "NoNull");

            migrationBuilder.DropTable(
                name: "Companies",
                schema: "NoNull");

            migrationBuilder.DropTable(
                name: "Professionists",
                schema: "NoNull");

            migrationBuilder.DropTable(
                name: "GeneralArea",
                schema: "NoNull");

            migrationBuilder.DropTable(
                name: "Destinations",
                schema: "NoNull");
        }
    }
}
