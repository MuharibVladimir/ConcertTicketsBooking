using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcertTicketsBooking.Migrations
{
    /// <inheritdoc />
    public partial class addvoicetypetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concerts_VoiceType_VoiceTypeId",
                table: "Concerts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VoiceType",
                table: "VoiceType");

            migrationBuilder.RenameTable(
                name: "VoiceType",
                newName: "VoiceTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VoiceTypes",
                table: "VoiceTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Concerts_VoiceTypes_VoiceTypeId",
                table: "Concerts",
                column: "VoiceTypeId",
                principalTable: "VoiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concerts_VoiceTypes_VoiceTypeId",
                table: "Concerts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VoiceTypes",
                table: "VoiceTypes");

            migrationBuilder.RenameTable(
                name: "VoiceTypes",
                newName: "VoiceType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VoiceType",
                table: "VoiceType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Concerts_VoiceType_VoiceTypeId",
                table: "Concerts",
                column: "VoiceTypeId",
                principalTable: "VoiceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
