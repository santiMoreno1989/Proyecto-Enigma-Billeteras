using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace enigmaBilleteras.Migrations
{
    public partial class Cargarlogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImagBilletera",
                table: "billeteras",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagBilletera",
                table: "billeteras");
        }
    }
}
