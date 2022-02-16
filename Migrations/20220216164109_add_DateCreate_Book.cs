using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinForms_Auth.Migrations
{
    public partial class add_DateCreate_Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2ff7e9b4-01a9-4de2-b57b-918ae72a80b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4df1af80-1d67-40cc-a9cc-93b3eca25054"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0d8137b4-06a0-4170-b818-c1c943437dec"));

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("8672234c-e6d1-4401-b333-ee2923bd8bcf"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("2ff7e9b4-01a9-4de2-b57b-918ae72a80b6"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2e79771e-1fc1-4045-8f87-dbe04a16832b"), "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("8672234c-e6d1-4401-b333-ee2923bd8bcf"), "Guest" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Email", "Name", "Password", "RoleId" },
                values: new object[] { new Guid("ff055b39-28b3-498e-853e-ae022c775366"), null, "admin@admin.com", "Admin", null, new Guid("2e79771e-1fc1-4045-8f87-dbe04a16832b") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8672234c-e6d1-4401-b333-ee2923bd8bcf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff055b39-28b3-498e-853e-ae022c775366"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2e79771e-1fc1-4045-8f87-dbe04a16832b"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Books");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("2ff7e9b4-01a9-4de2-b57b-918ae72a80b6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("8672234c-e6d1-4401-b333-ee2923bd8bcf"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0d8137b4-06a0-4170-b818-c1c943437dec"), "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2ff7e9b4-01a9-4de2-b57b-918ae72a80b6"), "Guest" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Email", "Name", "Password", "RoleId" },
                values: new object[] { new Guid("4df1af80-1d67-40cc-a9cc-93b3eca25054"), null, "admin@admin.com", "Admin", null, new Guid("0d8137b4-06a0-4170-b818-c1c943437dec") });
        }
    }
}
