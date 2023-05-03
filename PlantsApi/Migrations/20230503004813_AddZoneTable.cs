using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlantsApi.Migrations
{
    /// <inheritdoc />
    public partial class AddZoneTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZoneMax",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "ZoneMin",
                table: "Plants");

            migrationBuilder.RenameColumn(
                name: "Zone",
                table: "Plants",
                newName: "Variant");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BinomialNomenclature",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AltName1",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AltName2",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AltName3",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZoneMin = table.Column<int>(type: "int", nullable: false),
                    ZoneMax = table.Column<int>(type: "int", nullable: false),
                    PlantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zones_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zones_PlantId",
                table: "Zones",
                column: "PlantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropColumn(
                name: "AltName1",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "AltName2",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "AltName3",
                table: "Plants");

            migrationBuilder.RenameColumn(
                name: "Variant",
                table: "Plants",
                newName: "Zone");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BinomialNomenclature",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZoneMax",
                table: "Plants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZoneMin",
                table: "Plants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
