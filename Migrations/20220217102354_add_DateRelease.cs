using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinForms_Auth.Migrations
{
    public partial class add_DateRelease : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("3c643b9d-a52c-4271-ace5-19a3aa578831"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("8d7e2dfd-18a9-49d9-9942-fca3806cedc4"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRelease",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f15d83d1-b00e-4078-ae3f-139ac9e75513"), "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("3c643b9d-a52c-4271-ace5-19a3aa578831"), "Guest" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Email", "Name", "Password", "RoleId" },
                values: new object[] { new Guid("296c54cd-fc6f-475b-b3db-2b6af1bb8541"), null, "admin@admin.com", "Admin", null, new Guid("f15d83d1-b00e-4078-ae3f-139ac9e75513") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3c643b9d-a52c-4271-ace5-19a3aa578831"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("296c54cd-fc6f-475b-b3db-2b6af1bb8541"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f15d83d1-b00e-4078-ae3f-139ac9e75513"));

            migrationBuilder.DropColumn(
                name: "DateRelease",
                table: "Books");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("8d7e2dfd-18a9-49d9-9942-fca3806cedc4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("3c643b9d-a52c-4271-ace5-19a3aa578831"));

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
    }
}
