using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelOLYMPO.Migrations
{
    public partial class inputdatahotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    Telefone = table.Column<int>(nullable: false),
                    NumeruQuarto = table.Column<int>(nullable: false),
                    NumeruAduto = table.Column<int>(nullable: false),
                    Checkin = table.Column<string>(nullable: true),
                    Checkout = table.Column<string>(nullable: true),
                    Ano = table.Column<string>(nullable: true),
                    Detalhes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserva");
        }
    }
}
