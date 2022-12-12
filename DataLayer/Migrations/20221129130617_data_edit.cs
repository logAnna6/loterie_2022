using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class dataedit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Games_game_id1",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Players_Playersplayer_id",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_Playersplayer_id",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Playersplayer_id",
                table: "Players");

            migrationBuilder.AlterColumn<int>(
                name: "game_id1",
                table: "Players",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Games_game_id1",
                table: "Players",
                column: "game_id1",
                principalTable: "Games",
                principalColumn: "game_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Games_game_id1",
                table: "Players");

            migrationBuilder.AlterColumn<int>(
                name: "game_id1",
                table: "Players",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "Playersplayer_id",
                table: "Players",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Players_Playersplayer_id",
                table: "Players",
                column: "Playersplayer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Games_game_id1",
                table: "Players",
                column: "game_id1",
                principalTable: "Games",
                principalColumn: "game_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Players_Playersplayer_id",
                table: "Players",
                column: "Playersplayer_id",
                principalTable: "Players",
                principalColumn: "player_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
