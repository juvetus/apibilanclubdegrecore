using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiBilanClubDegre.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    Question1 = table.Column<string>(type: "text", nullable: false),
                    Question2 = table.Column<string>(type: "text", nullable: false),
                    Question3 = table.Column<string>(type: "text", nullable: false),
                    Question4 = table.Column<string>(type: "text", nullable: false),
                    Question5 = table.Column<string>(type: "text", nullable: false),
                    Question6 = table.Column<string>(type: "text", nullable: false),
                    Question7 = table.Column<string>(type: "text", nullable: false),
                    Question8 = table.Column<string>(type: "text", nullable: false),
                    Question9 = table.Column<string>(type: "text", nullable: false),
                    Question10 = table.Column<string>(type: "text", nullable: false),
                    Question11 = table.Column<string>(type: "text", nullable: false),
                    Question12 = table.Column<string>(type: "text", nullable: false),
                    Question13 = table.Column<string>(type: "text", nullable: false),
                    Question14 = table.Column<string>(type: "text", nullable: false),
                    Question15 = table.Column<string>(type: "text", nullable: false),
                    Question16 = table.Column<string>(type: "text", nullable: false),
                    Question17 = table.Column<string>(type: "text", nullable: false),
                    Question18 = table.Column<string>(type: "text", nullable: false),
                    Question19 = table.Column<string>(type: "text", nullable: false),
                    Question20 = table.Column<string>(type: "text", nullable: false),
                    Question21 = table.Column<string>(type: "text", nullable: false),
                    Question22 = table.Column<string>(type: "text", nullable: false),
                    Question23 = table.Column<string>(type: "text", nullable: false),
                    Question24 = table.Column<string>(type: "text", nullable: false),
                    Question25 = table.Column<string>(type: "text", nullable: false),
                    Question26 = table.Column<string>(type: "text", nullable: false),
                    Question27 = table.Column<string>(type: "text", nullable: false),
                    Question28 = table.Column<string>(type: "text", nullable: false),
                    Question29 = table.Column<string>(type: "text", nullable: false),
                    Question30 = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
