using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.DAL.Migrations
{
    public partial class CreateShopDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
