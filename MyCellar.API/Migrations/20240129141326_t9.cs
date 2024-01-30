using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCellar.API.Migrations
{
    public partial class t9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$D5CqX7KySzOHyz6nT6rUSe7e2DhzKW7VlhP.QEoOOYkoX.FDPOLcm");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$xSeXGF.hZnqteckv0FnRwuTx3xGT.AJYxWgyViF0oDPEMYi9z9b/O");
        }
    }
}
