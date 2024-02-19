using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Merchant_Portal.Migrations
{
    /// <inheritdoc />
    public partial class SeededUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "4b6029f2-6ce5-4bb4-83a4-96a98786d237");

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "80671efe-13b8-443c-91eb-d8550859b294");

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "aa7f8586-a1dd-4d58-84b1-17f4db3563de");

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: "fe8205b4-3b53-46d9-bad3-2baf5e871982");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "UserId", "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9880), new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9908), new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "UserId", "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9923), new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9926), new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "UserId", "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9933), new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "UserId", "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7", new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9957), new DateTime(2028, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 2, 19, 15, 30, 47, 129, DateTimeKind.Local).AddTicks(9957) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "UserId", "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { "92f5eaa0-0e23-4766-8a41-7658f7b125bb", new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8228), new DateTime(2028, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "UserId", "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { "92f5eaa0-0e23-4766-8a41-7658f7b125bb", new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8264), new DateTime(2028, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "UserId", "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { "92f5eaa0-0e23-4766-8a41-7658f7b125bb", new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8273), new DateTime(2028, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8276), new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "UserId", "createdAt", "expiryDate", "updatedAt" },
                values: new object[] { "92f5eaa0-0e23-4766-8a41-7658f7b125bb", new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8296), new DateTime(2028, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8300), new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AppUserId", "Description", "UserId", "cardId", "createdAt", "deletedAt", "transAmount", "transReferenceNumber", "transactionType", "transactionstatus", "updatedAt" },
                values: new object[,]
                {
                    { "4b6029f2-6ce5-4bb4-83a4-96a98786d237", null, "My_Withdrawal", "92f5eaa0-0e23-4766-8a41-7658f7b125bb", "2", new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8355), null, 3500.4499999999998, "Ref323115", 1, 0, new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8355) },
                    { "80671efe-13b8-443c-91eb-d8550859b294", null, "My_Funding", "92f5eaa0-0e23-4766-8a41-7658f7b125bb", "1", new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8337), null, 5000.0, "Ref323112", 0, 0, new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8338) },
                    { "aa7f8586-a1dd-4d58-84b1-17f4db3563de", null, "My_Funding", "92f5eaa0-0e23-4766-8a41-7658f7b125bb", "1", new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8349), null, 1500.8699999999999, "Ref323114", 0, 0, new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8350) },
                    { "fe8205b4-3b53-46d9-bad3-2baf5e871982", null, "My_Withdrawal", "92f5eaa0-0e23-4766-8a41-7658f7b125bb", "1", new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8344), null, 3500.5599999999999, "Ref323113", 1, 1, new DateTime(2024, 2, 19, 15, 16, 54, 500, DateTimeKind.Local).AddTicks(8344) }
                });
        }
    }
}
