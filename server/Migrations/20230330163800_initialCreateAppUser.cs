using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class initialCreateAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "ProductDetails");
        }
    }
}
