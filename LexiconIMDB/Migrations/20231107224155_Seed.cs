using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LexiconIMDB.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 3, 2f, new DateTime(1997, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titanic" },
                    { 2, 0, 2.3f, new DateTime(2005, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scream" },
                    { 3, 0, 4.4f, new DateTime(1997, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { 4, 4, 4.1f, new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "300" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
