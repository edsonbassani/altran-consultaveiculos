using Microsoft.EntityFrameworkCore.Migrations;

namespace DevCo.ConsultaVeiculos.WebAPI.Migrations
{
    public partial class DBCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    IdVeiculo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false),
                    Proprietario = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Veiculo_Roubado = table.Column<bool>(type: "bit", nullable: false),
                    Ano_Fabricacao = table.Column<short>(type: "smallint", maxLength: 4, nullable: false),
                    Ano_Modelo = table.Column<short>(type: "smallint", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.IdVeiculo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
