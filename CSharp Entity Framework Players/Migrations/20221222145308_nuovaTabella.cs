using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class nuovaTabella : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Team_id",
                table: "players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Team_id1",
                table: "players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    Teamid = table.Column<int>(name: "Team_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    allenatore = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.Teamid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_players_Team_id1",
                table: "players",
                column: "Team_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_players_teams_Team_id1",
                table: "players",
                column: "Team_id1",
                principalTable: "teams",
                principalColumn: "Team_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_players_teams_Team_id1",
                table: "players");

            migrationBuilder.DropTable(
                name: "teams");

            migrationBuilder.DropIndex(
                name: "IX_players_Team_id1",
                table: "players");

            migrationBuilder.DropColumn(
                name: "Team_id",
                table: "players");

            migrationBuilder.DropColumn(
                name: "Team_id1",
                table: "players");
        }
    }
}
