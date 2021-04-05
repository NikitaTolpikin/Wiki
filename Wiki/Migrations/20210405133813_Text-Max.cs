using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wiki.Migrations
{
    public partial class TextMax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Текст статьи",
                table: "Словарная статья",
                maxLength: 3000,
                nullable: false,
                defaultValue: "Статья в разработке",
                oldClrType: typeof(string),
                oldType: "text",
                oldDefaultValue: "Статья в разработке");

            migrationBuilder.AlterColumn<string>(
                name: "Путь до изображения",
                table: "Словарная статья",
                maxLength: 3000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Путь до аудио",
                table: "Словарная статья",
                maxLength: 3000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Текст статьи",
                table: "Правка",
                maxLength: 3000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Путь до изображения",
                table: "Правка",
                maxLength: 3000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Путь до аудио",
                table: "Правка",
                maxLength: 3000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Текст комментария",
                table: "Комментарий",
                maxLength: 3000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 5, 20, 38, 13, 524, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 5, 20, 27, 27, 576, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Пользователь",
                columns: new[] { "ID пользователя", "e-mail", "Дата регистрации", "Дата рождения", "Имя", "Код категории", "Отчество", "Пароль", "Пол", "Фамилия" },
                values: new object[] { new Guid("82a4e074-c0e4-4d63-a421-0c777663b798"), "admin@admin.com", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", 2L, "Admin", "admin", true, "Admin" });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[,]
                {
                    { new Guid("93183ed3-f531-4850-a3e8-495ab2258178"), "Тепло" },
                    { new Guid("76886804-df87-4ed8-902b-c7a4a9642a22"), "Холодно" },
                    { new Guid("a9385093-51a8-47ea-8a59-22be3b700064"), "Лес" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Пользователь",
                keyColumn: "ID пользователя",
                keyValue: new Guid("82a4e074-c0e4-4d63-a421-0c777663b798"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("76886804-df87-4ed8-902b-c7a4a9642a22"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("93183ed3-f531-4850-a3e8-495ab2258178"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("a9385093-51a8-47ea-8a59-22be3b700064"));

            migrationBuilder.AlterColumn<string>(
                name: "Текст статьи",
                table: "Словарная статья",
                type: "text",
                nullable: false,
                defaultValue: "Статья в разработке",
                oldClrType: typeof(string),
                oldMaxLength: 3000,
                oldDefaultValue: "Статья в разработке");

            migrationBuilder.AlterColumn<string>(
                name: "Путь до изображения",
                table: "Словарная статья",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Путь до аудио",
                table: "Словарная статья",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Текст статьи",
                table: "Правка",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 3000);

            migrationBuilder.AlterColumn<string>(
                name: "Путь до изображения",
                table: "Правка",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Путь до аудио",
                table: "Правка",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Текст комментария",
                table: "Комментарий",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 3000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 5, 20, 27, 27, 576, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 5, 20, 38, 13, 524, DateTimeKind.Local));

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
    }
}
