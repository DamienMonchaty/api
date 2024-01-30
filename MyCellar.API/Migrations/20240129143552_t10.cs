using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCellar.API.Migrations
{
    public partial class t10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$UwCXXWz4t9jtTXcfiJTAgeqLRuY17xPI.UuYwStNWJfJJ3qGPN7Lm");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$.DHayoB1TKxT9PDEHTQNgeRclRgtgRfU/mn6imdYLEqXuDkstP8IG");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$oRdNfkCQqokJKQVwxe3fGu4wTP8x53piShTX6pk/4iw6dPPlWou/i");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$Nlj4lFVR/eNZvlkHKqTmMusNJzkLqevi/ccX4e93QeXUEvwpihpNK");
        }
    }
}
