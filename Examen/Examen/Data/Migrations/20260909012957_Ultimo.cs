using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Data.Migrations
{
    /// <inheritdoc />
    public partial class Ultimo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaVencimiento",
                table: "Tarea",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FechaVencimiento",
                table: "Tarea",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }
    }
}
