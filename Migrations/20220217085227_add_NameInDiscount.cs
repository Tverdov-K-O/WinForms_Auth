using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinForms_Auth.Migrations
{
    public partial class add_NameInDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d9f3d504-d6c9-4ec4-9395-e02ae1deeacc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f1e9c57-bbd4-4ea5-9251-27fc8aa849de"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77607aa2-53dc-4a30-9227-09264242fb65"));

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("8d7e2dfd-18a9-49d9-9942-fca3806cedc4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("d9f3d504-d6c9-4ec4-9395-e02ae1deeacc"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Discounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9e76a841-4f38-4b2a-97e9-0fff92aba3fe"), "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("8d7e2dfd-18a9-49d9-9942-fca3806cedc4"), "Guest" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Email", "Name", "Password", "RoleId" },
                values: new object[] { new Guid("acddd8b1-5bef-4eb4-a12c-997dd2cb3188"), null, "admin@admin.com", "Admin", null, new Guid("9e76a841-4f38-4b2a-97e9-0fff92aba3fe") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d7e2dfd-18a9-49d9-9942-fca3806cedc4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("acddd8b1-5bef-4eb4-a12c-997dd2cb3188"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e76a841-4f38-4b2a-97e9-0fff92aba3fe"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Discounts");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("d9f3d504-d6c9-4ec4-9395-e02ae1deeacc"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("8d7e2dfd-18a9-49d9-9942-fca3806cedc4"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("77607aa2-53dc-4a30-9227-09264242fb65"), "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d9f3d504-d6c9-4ec4-9395-e02ae1deeacc"), "Guest" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Email", "Name", "Password", "RoleId" },
                values: new object[] { new Guid("1f1e9c57-bbd4-4ea5-9251-27fc8aa849de"), null, "admin@admin.com", "Admin", null, new Guid("77607aa2-53dc-4a30-9227-09264242fb65") });
        }
    }
}
