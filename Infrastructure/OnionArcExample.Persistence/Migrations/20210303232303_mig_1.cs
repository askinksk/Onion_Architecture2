using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnionArcExample.Persistence.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("6d46d7e5-6fa2-4ecf-b0cd-d8c4a3bce5a6"), "Product 1 Description", "Product 1", 1000, 10 },
                    { new Guid("f66a0255-bf2a-47bd-a05d-85e61c317d68"), "Product 2 Description", "Product 2", 2000, 20 },
                    { new Guid("793f39e8-76f0-49fe-b68c-8f61d3c2db8a"), "Product 3 Description", "Product 3", 3000, 30 },
                    { new Guid("c657f0ea-ae3b-4cce-8091-9bc8eccd68ff"), "Product 4 Description", "Product 4", 4000, 40 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
