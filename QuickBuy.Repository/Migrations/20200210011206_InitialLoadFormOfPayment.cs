using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repository.Migrations
{
    public partial class InitialLoadFormOfPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormsOfPayment",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 1, "Form of Payment - Bill", "Bill" });

            migrationBuilder.InsertData(
                table: "FormsOfPayment",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 2, "Form of Payment - Credit Card", "CreditCard" });

            migrationBuilder.InsertData(
                table: "FormsOfPayment",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 3, "Form of Payment - Deposity", "Deposity" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormsOfPayment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormsOfPayment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormsOfPayment",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
