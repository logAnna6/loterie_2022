using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class adddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    gameid = table.Column<int>(name: "game_id", type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    gamenum1 = table.Column<int>(name: "game_num1", type: "INTEGER", nullable: false),
                    gamenum2 = table.Column<int>(name: "game_num2", type: "INTEGER", nullable: false),
                    gamenum3 = table.Column<int>(name: "game_num3", type: "INTEGER", nullable: false),
                    gamenum4 = table.Column<int>(name: "game_num4", type: "INTEGER", nullable: false),
                    gamenum5 = table.Column<int>(name: "game_num5", type: "INTEGER", nullable: false),
                    gamenum6 = table.Column<int>(name: "game_num6", type: "INTEGER", nullable: false),
                    gameprize = table.Column<int>(name: "game_prize", type: "INTEGER", nullable: false),
                    gamestartdate = table.Column<DateTime>(name: "game_startdate", type: "TEXT", nullable: false),
                    gameenddate = table.Column<DateTime>(name: "game_enddate", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.gameid);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    playerid = table.Column<int>(name: "player_id", type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    playercode = table.Column<string>(name: "player_code", type: "TEXT", nullable: false),
                    playernum1 = table.Column<int>(name: "player_num1", type: "INTEGER", nullable: false),
                    playernum2 = table.Column<int>(name: "player_num2", type: "INTEGER", nullable: false),
                    playernum3 = table.Column<int>(name: "player_num3", type: "INTEGER", nullable: false),
                    playernum4 = table.Column<int>(name: "player_num4", type: "INTEGER", nullable: false),
                    playernum5 = table.Column<int>(name: "player_num5", type: "INTEGER", nullable: false),
                    playernum6 = table.Column<int>(name: "player_num6", type: "INTEGER", nullable: false),
                    playerprize = table.Column<int>(name: "player_prize", type: "INTEGER", nullable: false),
                    playerregdate = table.Column<DateTime>(name: "player_reg_date", type: "TEXT", nullable: false),
                    gameid = table.Column<int>(name: "game_id", type: "INTEGER", nullable: false),
                    Playersplayerid = table.Column<int>(name: "Playersplayer_id", type: "INTEGER", nullable: false),
                    gameid1 = table.Column<int>(name: "game_id1", type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.playerid);
                    table.ForeignKey(
                        name: "FK_Players_Games_game_id1",
                        column: x => x.gameid1,
                        principalTable: "Games",
                        principalColumn: "game_id");
                    table.ForeignKey(
                        name: "FK_Players_Players_Playersplayer_id",
                        column: x => x.Playersplayerid,
                        principalTable: "Players",
                        principalColumn: "player_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_game_id1",
                table: "Players",
                column: "game_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Players_Playersplayer_id",
                table: "Players",
                column: "Playersplayer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
