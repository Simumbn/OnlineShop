﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShopping.Data.Migrations
{
    public partial class s02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");
        }
    }
}
