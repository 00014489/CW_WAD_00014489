using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW_MovieApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Actor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ActorId",
                table: "Movies",
                column: "ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Actors_ActorId",
                table: "Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Actors_ActorId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ActorId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Movies");
        }
    }
}
