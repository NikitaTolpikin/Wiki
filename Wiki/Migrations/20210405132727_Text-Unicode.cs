using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wiki.Migrations
{
    public partial class TextUnicode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Пользователь",
                keyColumn: "ID пользователя",
                keyValue: new Guid("9625f0f3-b1fe-4381-9688-866916237b98"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("2df388d8-44c2-4e5e-bec1-6f479e5a327f"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("88038bd4-567f-4a62-b13d-516a02e97903"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("9faf6a05-5e0c-414d-8171-9ddcd33185bd"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 5, 20, 27, 27, 576, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 5, 20, 17, 9, 176, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Пользователь",
                columns: new[] { "ID пользователя", "e-mail", "Дата регистрации", "Дата рождения", "Имя", "Код категории", "Отчество", "Пароль", "Пол", "Фамилия" },
                values: new object[] { new Guid("ddd41bc8-3211-45bd-b88c-640f05493722"), "admin@admin.com", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", 2L, "Admin", "admin", true, "Admin" });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[,]
                {
                    { new Guid("276c8463-3be8-48b1-ad74-4028a29f7053"), "Тепло" },
                    { new Guid("7f9f3deb-5e71-42c2-8a50-5803e5de8360"), "Холодно" },
                    { new Guid("6c9d2ea1-c739-42cc-8542-85a7937520f1"), "Лес" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Пользователь",
                keyColumn: "ID пользователя",
                keyValue: new Guid("ddd41bc8-3211-45bd-b88c-640f05493722"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("276c8463-3be8-48b1-ad74-4028a29f7053"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("6c9d2ea1-c739-42cc-8542-85a7937520f1"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("7f9f3deb-5e71-42c2-8a50-5803e5de8360"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 5, 20, 17, 9, 176, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 5, 20, 27, 27, 576, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Пользователь",
                columns: new[] { "ID пользователя", "e-mail", "Дата регистрации", "Дата рождения", "Имя", "Код категории", "Отчество", "Пароль", "Пол", "Фамилия" },
                values: new object[] { new Guid("9625f0f3-b1fe-4381-9688-866916237b98"), "admin@admin.com", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", 2L, "Admin", "admin", true, "Admin" });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[,]
                {
                    { new Guid("88038bd4-567f-4a62-b13d-516a02e97903"), "Тепло" },
                    { new Guid("2df388d8-44c2-4e5e-bec1-6f479e5a327f"), "Холодно" },
                    { new Guid("9faf6a05-5e0c-414d-8171-9ddcd33185bd"), "Лес" }
                });
        }
    }
}
