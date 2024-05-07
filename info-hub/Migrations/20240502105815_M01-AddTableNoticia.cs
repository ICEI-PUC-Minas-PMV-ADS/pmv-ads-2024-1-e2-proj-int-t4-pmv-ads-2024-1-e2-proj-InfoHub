using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace info_hub.Migrations
{
    /// <inheritdoc />
    public partial class M01AddTableNoticia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Noticias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tema = table.Column<string>(type: "string", nullable: false),
                    Titulo = table.Column<string>(type: "string", nullable: false),
                    DataPublicacao = table.Column<string>(type: "string", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticias", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noticias");
        }
    }
}
