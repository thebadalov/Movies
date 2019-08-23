using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie.Data.Migrations
{
    public partial class Migration_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieEpisodePersonCharacters");

            migrationBuilder.DropTable(
                name: "MoviePersons");

            migrationBuilder.DropTable(
                name: "MovieEpisodePersons");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.AddColumn<int>(
                name: "Episode",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MovieKind",
                table: "Movies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Season",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Chracters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Chracters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chracters_MovieId",
                table: "Chracters",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Chracters_PersonId",
                table: "Chracters",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MovieId",
                table: "Comments",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chracters_Movies_MovieId",
                table: "Chracters",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chracters_Persons_PersonId",
                table: "Chracters",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chracters_Movies_MovieId",
                table: "Chracters");

            migrationBuilder.DropForeignKey(
                name: "FK_Chracters_Persons_PersonId",
                table: "Chracters");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Chracters_MovieId",
                table: "Chracters");

            migrationBuilder.DropIndex(
                name: "IX_Chracters_PersonId",
                table: "Chracters");

            migrationBuilder.DropColumn(
                name: "Episode",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieKind",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Season",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Chracters");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Chracters");

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Duration = table.Column<string>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    ReleaseAt = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodes_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoviePersons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharacterId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    PersonType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoviePersons_Chracters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Chracters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviePersons_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviePersons_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieEpisodePersons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EpisodeId = table.Column<int>(nullable: false),
                    IsDirector = table.Column<bool>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieEpisodePersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieEpisodePersons_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieEpisodePersons_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieEpisodePersonCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharacterId = table.Column<int>(nullable: false),
                    MovieEpisodePersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieEpisodePersonCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieEpisodePersonCharacters_Chracters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Chracters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieEpisodePersonCharacters_MovieEpisodePersons_MovieEpisodePersonId",
                        column: x => x.MovieEpisodePersonId,
                        principalTable: "MovieEpisodePersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_MovieId",
                table: "Episodes",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieEpisodePersonCharacters_CharacterId",
                table: "MovieEpisodePersonCharacters",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieEpisodePersonCharacters_MovieEpisodePersonId",
                table: "MovieEpisodePersonCharacters",
                column: "MovieEpisodePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieEpisodePersons_EpisodeId",
                table: "MovieEpisodePersons",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieEpisodePersons_PersonId",
                table: "MovieEpisodePersons",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePersons_CharacterId",
                table: "MoviePersons",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePersons_MovieId",
                table: "MoviePersons",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePersons_PersonId",
                table: "MoviePersons",
                column: "PersonId");
        }
    }
}
