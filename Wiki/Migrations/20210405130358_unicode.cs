using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wiki.Migrations
{
    public partial class unicode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Часть речи",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Тег",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Статус правки",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Слово",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Словарная статья",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Правка",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Фамилия",
                table: "Пользователь",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Пароль",
                table: "Пользователь",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Отчество",
                table: "Пользователь",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Имя",
                table: "Пользователь",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "e-mail",
                table: "Пользователь",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 5, 20, 3, 58, 363, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 5, 14, 42, 20, 683, DateTimeKind.Local));

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Категория пользователя",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "Пользователь",
                columns: new[] { "ID пользователя", "e-mail", "Дата регистрации", "Дата рождения", "Имя", "Код категории", "Отчество", "Пароль", "Пол", "Фамилия" },
                values: new object[] { new Guid("95675a84-6bc9-461e-bbe0-51d40b635fe2"), "admin@admin.com", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", 2L, "Admin", "admin", true, "Admin" });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[,]
                {
                    { new Guid("cab2a80d-7cfc-4aa1-878f-885a3c030621"), "Тепло" },
                    { new Guid("148a1960-9c36-4bca-9835-28a7ea1d6402"), "Холодно" },
                    { new Guid("d06594b5-8e8f-4f7e-8ec7-6cb0d6d9ac4e"), "Лес" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Пользователь",
                keyColumn: "ID пользователя",
                keyValue: new Guid("95675a84-6bc9-461e-bbe0-51d40b635fe2"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("148a1960-9c36-4bca-9835-28a7ea1d6402"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("cab2a80d-7cfc-4aa1-878f-885a3c030621"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("d06594b5-8e8f-4f7e-8ec7-6cb0d6d9ac4e"));

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Часть речи",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Тег",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Статус правки",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Слово",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Словарная статья",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Правка",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Фамилия",
                table: "Пользователь",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Пароль",
                table: "Пользователь",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Отчество",
                table: "Пользователь",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Имя",
                table: "Пользователь",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "e-mail",
                table: "Пользователь",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 5, 14, 42, 20, 683, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 5, 20, 3, 58, 363, DateTimeKind.Local));

            migrationBuilder.AlterColumn<string>(
                name: "Название",
                table: "Категория пользователя",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

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
    }
}
