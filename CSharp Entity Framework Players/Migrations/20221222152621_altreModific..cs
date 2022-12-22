using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class altreModific : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_players_teams_Team_id1",
                table: "players");

            migrationBuilder.DropColumn(
                name: "Team_id",
                table: "players");

            migrationBuilder.RenameColumn(
                name: "Team_id",
                table: "teams",
                newName: "TeamId");

            migrationBuilder.RenameColumn(
                name: "Team_id1",
                table: "players",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_players_Team_id1",
                table: "players",
                newName: "IX_players_TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_players_teams_TeamId",
                table: "players",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_players_teams_TeamId",
                table: "players");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "teams",
                newName: "Team_id");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "players",
                newName: "Team_id1");

            migrationBuilder.RenameIndex(
                name: "IX_players_TeamId",
                table: "players",
                newName: "IX_players_Team_id1");

            migrationBuilder.AddColumn<int>(
                name: "Team_id",
                table: "players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_players_teams_Team_id1",
                table: "players",
                column: "Team_id1",
                principalTable: "teams",
                principalColumn: "Team_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
