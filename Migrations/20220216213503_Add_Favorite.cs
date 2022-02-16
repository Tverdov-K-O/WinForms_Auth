using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinForms_Auth.Migrations
{
    public partial class Add_Favorite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("d9f3d504-d6c9-4ec4-9395-e02ae1deeacc"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("8672234c-e6d1-4401-b333-ee2923bd8bcf"));

            migrationBuilder.CreateTable(
                name: "BookUser",
                columns: table => new
                {
                    BooksId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookUser", x => new { x.BooksId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_BookUser_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BookUser_UsersId",
                table: "BookUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookUser");

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
                defaultValue: new Guid("8672234c-e6d1-4401-b333-ee2923bd8bcf"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("d9f3d504-d6c9-4ec4-9395-e02ae1deeacc"));

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
    }
}
