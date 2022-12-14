using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApi.Dao.Model.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bakerys",
                columns: table => new
                {
                    BakeryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BakeryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxBreads = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakerys", x => x.BakeryId);
                });

            migrationBuilder.CreateTable(
                name: "Breads",
                columns: table => new
                {
                    BreadDaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreadDaoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breads", x => x.BreadDaoId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCost = table.Column<float>(type: "real", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BakeryDaoBakeryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Bakerys_BakeryDaoBakeryId",
                        column: x => x.BakeryDaoBakeryId,
                        principalTable: "Bakerys",
                        principalColumn: "BakeryId");
                });

            migrationBuilder.CreateTable(
                name: "OrderBreads",
                columns: table => new
                {
                    OrderBreadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDaoId = table.Column<int>(type: "int", nullable: false),
                    BreadDaoId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBreads", x => x.OrderBreadId);
                    table.ForeignKey(
                        name: "FK_OrderBreads_Breads_BreadDaoId",
                        column: x => x.BreadDaoId,
                        principalTable: "Breads",
                        principalColumn: "BreadDaoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderBreads_Orders_OrderDaoId",
                        column: x => x.OrderDaoId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderBreads_BreadDaoId",
                table: "OrderBreads",
                column: "BreadDaoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBreads_OrderDaoId",
                table: "OrderBreads",
                column: "OrderDaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BakeryDaoBakeryId",
                table: "Orders",
                column: "BakeryDaoBakeryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderBreads");

            migrationBuilder.DropTable(
                name: "Breads");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Bakerys");
        }
    }
}
