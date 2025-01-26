using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetIdentityWithJWT.Migrations
{
    public partial class seedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06bfa252-3a8e-4713-8a07-b9052e956a42", "5fd3f0ad-d07f-450f-9fa2-3867aedce914", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70a577ea-0f21-44cf-a029-f9abbbd8e99b", "d464d22a-4211-4ff6-9f56-7eeec00bb48a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06bfa252-3a8e-4713-8a07-b9052e956a42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70a577ea-0f21-44cf-a029-f9abbbd8e99b");
        }
    }
}
