using Microsoft.EntityFrameworkCore.Migrations;

namespace Crm.DataAccess.Migrations
{
    public partial class TablesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Engineering", "Technology" },
                    { 2, "Picture", "Art" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Mail", "Name", "Phone", "Surname" },
                values: new object[,]
                {
                    { 1, "jj@mail.com", "Jane", "5553337788", "Joe" },
                    { 2, "cc@mail.com", "Chris", "4442226677", "Cor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
