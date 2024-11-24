using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPlusSport.Security.Web.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "IMjeecsYY5xv3VAz7YwYdsMPnIk=", "", "LVN6lnMue4QWpQ84n2FTmiHeT/wqs8X2NwZp4GL97tM=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "8bI1kekGQohDWJHDTW6XIQ8am0Q=", "", "X9iw4nSZMGaHF4v/c3IebaCbv8BaUe5Fq7iKYHFErto=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "", "Adam's secret", "" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "", "b@rb@r@", "" });
        }
    }
}
