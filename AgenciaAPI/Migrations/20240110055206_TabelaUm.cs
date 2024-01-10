using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgenciaAPI.Migrations
{
    /// <inheritdoc />
    public partial class TabelaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "reservas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroCpf = table.Column<long>(type: "bigint", nullable: false),
                    NumeroTelefone = table.Column<long>(type: "bigint", nullable: false),
                    DataViagem = table.Column<DateTime>(type: "datetime", nullable: false),
                    QuantidadePessoas = table.Column<long>(type: "bigint", nullable: false),
                    LocalDestino = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DestinoURL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorPassagem = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservas", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "reservas",
                columns: new[] { "id", "NumeroCpf", "DataViagem", "LocalDestino", "DestinoURL", "NomeCompleto", "NumeroTelefone", "QuantidadePessoas", "ValorPassagem" },
                values: new object[,]
                {
                    { 1, 9988890098L, new DateTime(2024, 2, 19, 10, 30, 0, 0, DateTimeKind.Unspecified), "Alagoas", "https://images.unsplash.com/photo-1625841028984-5a4c1a657e19?q=80&w=1473&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Bruce Dickinson", 81988880099L, 4L, 1.5820000000000001 },
                    { 2, 88876543212L, new DateTime(2024, 2, 10, 23, 58, 0, 0, DateTimeKind.Unspecified), "Recife", "https://images.unsplash.com/photo-1612383892465-153167840470?q=80&w=1374&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Steve Harris", 83977890000L, 7L, 1.6659999999999999 },
                    { 3, 12354376598L, new DateTime(2024, 2, 22, 17, 50, 0, 0, DateTimeKind.Unspecified), "Paraiba", "https://images.unsplash.com/photo-1604978472078-5a067d2d0426?q=80&w=1374&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Adrian Smith", 82977768896L, 3L, 1.288 },
                    { 4, 9867823465L, new DateTime(2024, 2, 15, 18, 30, 0, 0, DateTimeKind.Unspecified), "Maranhão", "https://images.unsplash.com/photo-1663641023872-00b4cfae9751?q=80&w=1404&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Nicko McBlain", 78976556565L, 6L, 1.95 },
                    { 5, 99777533101L, new DateTime(2024, 2, 12, 20, 35, 0, 0, DateTimeKind.Unspecified), "Natal", "https://images.unsplash.com/photo-1516242981651-2ee338449dea?q=80&w=1374&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Dave Murray", 21988800987L, 5L, 1.4890000000000001 },
                    { 6, 87699088765L, new DateTime(2024, 2, 18, 22, 45, 0, 0, DateTimeKind.Unspecified), "Sergipe", "https://images.unsplash.com/photo-1573484770405-d78bb704e7db?q=80&w=1470&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Janick Gers", 11988890987L, 3L, 1.899 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reservas");
        }
    }
}
