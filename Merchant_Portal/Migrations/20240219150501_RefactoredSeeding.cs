using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Merchant_Portal.Migrations
{
    /// <inheritdoc />
    public partial class RefactoredSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "08240136-f7d1-4a5e-8f53-29761217d4fd");

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "30bd71dc-169c-40c0-bdd8-e7dbcf36ec64");

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "410f1646-afdb-4d12-90f9-5a23a4bdc787");

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "479f9aa1-efb4-4c81-9797-708c1187d6db");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8304), new DateTime(2028, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8329), new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8339), new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8341), new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "cardName", "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { "Chike Bless", new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8358), new DateTime(2023, 10, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8360), new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8367), new DateTime(2028, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8369), new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AppUserId", "Description", "UserId", "cardId", "createdAt", "deletedAt", "transAmount", "transReferenceNumber", "transactionType", "transactionstatus", "updatedAt" },
                values: new object[,]
                {
                    { "0d3d5c95-d060-4a3f-a1bb-d1edf6367a1b", null, "My_Withdrawal", "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", "1", new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8402), null, 3500.5599999999999, "Ref323113", 1, 1, new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8403) },
                    { "40d1dad6-ae8f-4439-87de-9ae835d98736", null, "My_Withdrawal", "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", "2", new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8411), null, 3500.4499999999998, "Ref323115", 1, 0, new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8411) },
                    { "55fa65b8-391a-4843-926f-ffe68982b366", null, "My_Funding", "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", "1", new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8397), null, 5000.0, "Ref323112", 0, 0, new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8398) },
                    { "59fe7a9b-9df1-468d-b9b2-2a0ddf970d70", null, "My_Funding", "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", "1", new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8407), null, 1500.8699999999999, "Ref323114", 0, 0, new DateTime(2024, 2, 19, 16, 5, 1, 119, DateTimeKind.Local).AddTicks(8407) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "0d3d5c95-d060-4a3f-a1bb-d1edf6367a1b");

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "40d1dad6-ae8f-4439-87de-9ae835d98736");

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "55fa65b8-391a-4843-926f-ffe68982b366");

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "59fe7a9b-9df1-468d-b9b2-2a0ddf970d70");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9880), new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9908), new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9923), new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9926), new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "cardName", "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { "Chike Bless Bless", new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9933), new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9957), new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AppUserId", "Description", "UserId", "cardId", "createdAt", "deletedAt", "transAmount", "transReferenceNumber", "transactionType", "transactionstatus", "updatedAt" },
                values: new object[,]
                {
                    { "08240136-f7d1-4a5e-8f53-29761217d4fd", null, "My_Withdrawal", "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", "2", new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(42), null, 3500.4499999999998, "Ref323115", 1, 0, new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(42) },
                    { "30bd71dc-169c-40c0-bdd8-e7dbcf36ec64", null, "My_Funding", "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", "1", new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(35), null, 1500.8699999999999, "Ref323114", 0, 0, new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(36) },
                    { "410f1646-afdb-4d12-90f9-5a23a4bdc787", null, "My_Withdrawal", "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", "1", new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(28), null, 3500.5599999999999, "Ref323113", 1, 1, new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(28) },
                    { "479f9aa1-efb4-4c81-9797-708c1187d6db", null, "My_Funding", "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", "1", new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(17), null, 5000.0, "Ref323112", 0, 0, new DateTime(2024, 2, 19, 15, 30, 47, 130, DateTimeKind.Local).AddTicks(18) }
                });
        }
    }
}
