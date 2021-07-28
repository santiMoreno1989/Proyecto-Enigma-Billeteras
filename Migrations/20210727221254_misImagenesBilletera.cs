using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace enigmaBilleteras.Migrations
{
    public partial class misImagenesBilletera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImagenBilletera",
                table: "billeteras",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenBilletera",
                table: "billeteras");
        }
    }
}
