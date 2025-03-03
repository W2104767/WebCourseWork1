using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeaponShop.Migrations
{
    /// <inheritdoc />
    public partial class AddManufacturerIdToWeapon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufacturingId",
                table: "Weapons");

            migrationBuilder.RenameColumn(
                name: "OderDate",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Customers",
                newName: "LastName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "OderDate");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "Lastname");

            migrationBuilder.AddColumn<int>(
                name: "ManufacturingId",
                table: "Weapons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
