using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace enigmaBilleteras.Migrations
{
    public partial class eliminacionImagBilleteras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagBilletera",
                table: "billeteras");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImagBilletera",
                table: "billeteras",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
