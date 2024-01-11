using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agencia.Migrations
{
    /// <inheritdoc />
    public partial class twoversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "client_iconeclient",
                table: "clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "clients",
                keyColumn: "id",
                keyValue: 1,
                column: "client_iconeclient",
                value: "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191933_1280.png");

            migrationBuilder.UpdateData(
                table: "clients",
                keyColumn: "id",
                keyValue: 2,
                column: "client_iconeclient",
                value: "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191934_960_720.png");

            migrationBuilder.UpdateData(
                table: "clients",
                keyColumn: "id",
                keyValue: 3,
                column: "client_iconeclient",
                value: "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191933_1280.png");

            migrationBuilder.UpdateData(
                table: "clients",
                keyColumn: "id",
                keyValue: 4,
                column: "client_iconeclient",
                value: "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191933_1280.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "client_iconeclient",
                table: "clients");
        }
    }
}
