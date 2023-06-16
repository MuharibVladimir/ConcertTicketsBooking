using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcertTicketsBooking.Migrations
{
    /// <inheritdoc />
    public partial class Changevoicetyperelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VoiceType",
                table: "Concerts",
                newName: "VoiceTypeId");

            migrationBuilder.CreateTable(
                name: "VoiceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoiceType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_VoiceTypeId",
                table: "Concerts",
                column: "VoiceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Concerts_VoiceType_VoiceTypeId",
                table: "Concerts",
                column: "VoiceTypeId",
                principalTable: "VoiceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concerts_VoiceType_VoiceTypeId",
                table: "Concerts");

            migrationBuilder.DropTable(
                name: "VoiceType");

            migrationBuilder.DropIndex(
                name: "IX_Concerts_VoiceTypeId",
                table: "Concerts");

            migrationBuilder.RenameColumn(
                name: "VoiceTypeId",
                table: "Concerts",
                newName: "VoiceType");
        }
    }
}
