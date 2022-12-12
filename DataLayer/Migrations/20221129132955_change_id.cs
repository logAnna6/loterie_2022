using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class changeid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Games_game_id1",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "player_id",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "game_id1",
                table: "Players",
                newName: "gameId");

            migrationBuilder.RenameColumn(
                name: "game_id",
                table: "Players",
                newName: "playerId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_game_id1",
                table: "Players",
                newName: "IX_Players_gameId");

            migrationBuilder.RenameColumn(
                name: "game_id",
                table: "Games",
                newName: "gameId");

            migrationBuilder.AlterColumn<int>(
                name: "playerId",
                table: "Players",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "playerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Games_gameId",
                table: "Players",
                column: "gameId",
                principalTable: "Games",
                principalColumn: "gameId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Games_gameId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "gameId",
                table: "Players",
                newName: "game_id1");

            migrationBuilder.RenameColumn(
                name: "playerId",
                table: "Players",
                newName: "game_id");

            migrationBuilder.RenameIndex(
                name: "IX_Players_gameId",
                table: "Players",
                newName: "IX_Players_game_id1");

            migrationBuilder.RenameColumn(
                name: "gameId",
                table: "Games",
                newName: "game_id");

            migrationBuilder.AlterColumn<int>(
                name: "game_id",
                table: "Players",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "player_id",
                table: "Players",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "player_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Games_game_id1",
                table: "Players",
                column: "game_id1",
                principalTable: "Games",
                principalColumn: "game_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
