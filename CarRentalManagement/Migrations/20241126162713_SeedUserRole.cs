using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f68ed9e6-7af0-4d46-88ce-0f7e459a3266", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPsdNO2X5B/9ubqreOo+AZOGrnNB/Ejmzb9RwAYnHfNsZW3o+cFHC0jy7ABMIt6z2Q==", null, false, "d279f109-abfb-4db1-8628-79eb15e05c69", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(7817), new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(7819), new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(7962), new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(7964), new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(8029), new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(8031), new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(8032), new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(8033), new DateTime(2024, 11, 27, 0, 27, 13, 182, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8602), new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8604), new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8755), new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8757), new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8821), new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8823), new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8825), new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8826), new DateTime(2024, 11, 27, 0, 23, 21, 389, DateTimeKind.Local).AddTicks(8826) });
        }
    }
}
