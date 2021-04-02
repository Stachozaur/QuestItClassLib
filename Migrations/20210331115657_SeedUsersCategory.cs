using Microsoft.EntityFrameworkCore.Migrations;

namespace Job.it_ClassLib.Migrations
{
    public partial class SeedUsersCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuestCategory",
                columns: new[] { "QuestCategoryId", "IconFilepath", "Name" },
                values: new object[,]
                {
                    { 1, "/assets/images/hantla1.svg", "Sport" },
                    { 2, "/assets/images/dogev2_cat.svg", "Animals" },
                    { 3, "/assets/images/Barber_category.svg", "Barber" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "City", "Email", "FirstName", "LastName", "Password", "RoleId" },
                values: new object[] { 1, "Newcastle", "eddiehall@beast.com", "Eddie", "Hall", "25000kcal", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "City", "Email", "FirstName", "LastName", "Password", "RoleId" },
                values: new object[] { 2, "Milan", "lugii@barber.com", "Luigi", "Scissorio", "whisky2137", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "City", "Email", "FirstName", "LastName", "Password", "RoleId" },
                values: new object[] { 3, "Warszawa", "Mario@Pipeman.com", "Mario", "Pipeman", "sąsiadkaobok", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestCategory",
                keyColumn: "QuestCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestCategory",
                keyColumn: "QuestCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestCategory",
                keyColumn: "QuestCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 2);
        }
    }
}
