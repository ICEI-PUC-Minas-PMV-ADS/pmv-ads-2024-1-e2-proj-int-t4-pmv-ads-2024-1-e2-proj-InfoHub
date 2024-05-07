using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace info_hub.Migrations
{
    /// <inheritdoc />
    public partial class M02AddTableTema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Temas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Politica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mundo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Economia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tecnologia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Negócios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Viagens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clima = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Moda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Esporte = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Temas");
        }
    }
}
