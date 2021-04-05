using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wiki.Migrations
{
    public partial class add_admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("66f29c5b-3ad6-468f-b2c8-7fee42a617c6"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("c3c5feaf-5089-4025-93ce-d2803151b61b"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("f6a86d63-54f3-455d-a159-91fe73158ce8"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 5, 14, 42, 20, 683, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 4, 1, 52, 21, 897, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Пользователь",
                columns: new[] { "ID пользователя", "e-mail", "Дата регистрации", "Дата рождения", "Имя", "Код категории", "Отчество", "Пароль", "Пол", "Фамилия" },
                values: new object[] { new Guid("e93b7f35-c3ab-4c99-86f6-05ec93159f6a"), "admin@admin.com", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", 2L, "Admin", "admin", true, "Admin" });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[,]
                {
                    { new Guid("05cc5f6d-df2e-4b80-8a63-704521099b04"), "Тепло" },
                    { new Guid("c73cb1a4-950a-43c2-b033-4e2aeb64317e"), "Холодно" },
                    { new Guid("3c56bffc-42a7-4685-b3f8-80939c2ff5f8"), "Лес" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Пользователь",
                keyColumn: "ID пользователя",
                keyValue: new Guid("e93b7f35-c3ab-4c99-86f6-05ec93159f6a"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("05cc5f6d-df2e-4b80-8a63-704521099b04"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("3c56bffc-42a7-4685-b3f8-80939c2ff5f8"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("c73cb1a4-950a-43c2-b033-4e2aeb64317e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 4, 1, 52, 21, 897, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 5, 14, 42, 20, 683, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[] { new Guid("66f29c5b-3ad6-468f-b2c8-7fee42a617c6"), "Тепло" });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[] { new Guid("f6a86d63-54f3-455d-a159-91fe73158ce8"), "Холодно" });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[] { new Guid("c3c5feaf-5089-4025-93ce-d2803151b61b"), "Лес" });
        }
    }
}
