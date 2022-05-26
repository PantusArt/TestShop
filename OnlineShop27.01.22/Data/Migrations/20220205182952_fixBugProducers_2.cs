using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop27._01._22.Data.Migrations
{
    public partial class fixBugProducers_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_producers_ProducerId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producers",
                table: "producers");

            migrationBuilder.RenameTable(
                name: "producers",
                newName: "Producers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Producers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Producers_ProducerId",
                table: "Products",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Producers_ProducerId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Producers");

            migrationBuilder.RenameTable(
                name: "Producers",
                newName: "producers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producers",
                table: "producers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_producers_ProducerId",
                table: "Products",
                column: "ProducerId",
                principalTable: "producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
