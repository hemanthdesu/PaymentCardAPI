using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentCardAPI.Migrations
{
    public partial class DataTypechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SecurityCode",
                table: "PaymentDetails",
                type: "varchar(3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)");

            migrationBuilder.AlterColumn<string>(
                name: "ExprirationDate",
                table: "PaymentDetails",
                type: "varchar(5)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)");

            migrationBuilder.AlterColumn<string>(
                name: "CardOwerName",
                table: "PaymentDetails",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "PaymentDetails",
                type: "varchar(16)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SecurityCode",
                table: "PaymentDetails",
                type: "nvarchar(3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)");

            migrationBuilder.AlterColumn<string>(
                name: "ExprirationDate",
                table: "PaymentDetails",
                type: "nvarchar(5)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)");

            migrationBuilder.AlterColumn<string>(
                name: "CardOwerName",
                table: "PaymentDetails",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "PaymentDetails",
                type: "nvarchar(16)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(16)");
        }
    }
}
