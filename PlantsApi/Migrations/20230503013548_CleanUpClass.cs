using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlantsApi.Migrations
{
    /// <inheritdoc />
    public partial class CleanUpClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZoneMax",
                table: "Zones");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ZoneMax",
                table: "Zones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
