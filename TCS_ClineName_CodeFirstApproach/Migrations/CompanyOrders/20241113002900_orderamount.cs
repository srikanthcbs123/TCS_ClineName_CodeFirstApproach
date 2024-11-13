using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCS_ClineName_CodeFirstApproach.Migrations.CompanyOrders
{
    /// <inheritdoc />
    public partial class orderamount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "orderamount",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "orderamount",
                table: "Orders");
        }
    }
}
