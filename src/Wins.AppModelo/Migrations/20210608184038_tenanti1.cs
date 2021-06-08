using Microsoft.EntityFrameworkCore.Migrations;

namespace Wins.AppModelo.Migrations
{
    public partial class tenanti1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    TenantId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    TenantId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome", "TenantId" },
                values: new object[] { 1, "Pessoa 1", "tenant-1" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome", "TenantId" },
                values: new object[] { 2, "Pessoa 2", "tenant-2" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome", "TenantId" },
                values: new object[] { 3, "Pessoa 3", "tenant-2" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome", "TenantId" },
                values: new object[] { 4, "Pessoa 4", "tenant-3" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "TenantId" },
                values: new object[] { 1, "Produto 1", "tenant-1" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "TenantId" },
                values: new object[] { 2, "Produto 2", "tenant-2" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "TenantId" },
                values: new object[] { 3, "Produto 3", "tenant-2" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "TenantId" },
                values: new object[] { 4, "Produto 4", "tenant-3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
