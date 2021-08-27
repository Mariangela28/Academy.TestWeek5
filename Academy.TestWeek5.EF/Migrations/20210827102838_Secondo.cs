using Microsoft.EntityFrameworkCore.Migrations;

namespace Academy.TestWeek5.EF.Migrations
{
    public partial class Secondo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Piatto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipologia = table.Column<int>(type: "int", nullable: false),
                    Prezzo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piatto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Piatto",
                columns: new[] { "Id", "Descrizione", "Nome", "Prezzo", "Tipologia" },
                values: new object[,]
                {
                    { 1, "Lasagna con pesto", "Lasagna al pesto", 10.5, 0 },
                    { 2, "Aragosta con sugo", "Aragosta al sugo", 15.5, 1 },
                    { 3, "Patatine fritte", "Patatine", 7.5, 2 },
                    { 4, "biscotti savoiardi con crema al mascarpone caffè e cacao", "Tiramisù", 5.5, 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "1234", 1, "mrossi@abc.it" },
                    { 2, "5678", 0, "mari@abc.it" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piatto");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
