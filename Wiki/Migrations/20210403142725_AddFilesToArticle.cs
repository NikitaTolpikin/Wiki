using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wiki.Migrations
{
    public partial class AddFilesToArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("3b0f6400-7fed-4fd0-bb52-3d1b0af7d69a"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("dac65a36-cffd-4334-96db-a0b0d8bfe82c"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("ee0f006b-101b-4dfc-8610-94f0ed17da0c"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID слова",
                table: "Слово",
                nullable: false,
                defaultValue: new Guid("c8d41019-1fdc-4429-8cd1-802e85c59d70"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("e9247265-7f3e-432c-837f-9679e11d6cf5"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID статьи",
                table: "Словарная статья",
                nullable: false,
                defaultValue: new Guid("c4260e12-bc8b-4db4-bb3e-f5f9bf352440"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("c7267621-154d-4e44-ab34-ab141d795ce3"));

            migrationBuilder.AddColumn<string>(
                name: "Путь до аудио",
                table: "Словарная статья",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Путь до изображения",
                table: "Словарная статья",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ID правки",
                table: "Правка",
                nullable: false,
                defaultValue: new Guid("5e8cc784-3d1c-46e5-a4ea-a16a80bab331"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("45e91cf8-6f99-44e1-a83b-a773028a4a7e"));

            migrationBuilder.AddColumn<string>(
                name: "Путь до аудио",
                table: "Правка",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Путь до изображения",
                table: "Правка",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ID пользователя",
                table: "Пользователь",
                nullable: false,
                defaultValue: new Guid("6e213662-1dd8-4b17-ad17-9df1c426f5c5"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("221db561-24a7-4dc1-ab9a-a610aefdb28e"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID назначенного модератора",
                table: "Назначенный модератор",
                nullable: false,
                defaultValue: new Guid("fe20627d-23d2-4c9a-962c-72c08cbbb2cc"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("ed343975-1472-4363-9c62-f8c0bf21ff0a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 3, 21, 27, 25, 360, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 3, 20, 51, 51, 402, DateTimeKind.Local));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID комментария",
                table: "Комментарий",
                nullable: false,
                defaultValue: new Guid("08f919d1-a854-44a6-9822-38d637af36f6"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("f22938ba-445f-43b5-be5a-95b49329f5ac"));

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[] { new Guid("d8381738-6668-4dc1-b735-a97ca50dfbc8"), "Тепло" });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[] { new Guid("95b3295b-72d0-4b6a-873a-4089b09c8861"), "Холодно" });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[] { new Guid("218d12fb-a103-4c6f-b2bb-ba9f30029590"), "Лес" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("218d12fb-a103-4c6f-b2bb-ba9f30029590"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("95b3295b-72d0-4b6a-873a-4089b09c8861"));

            migrationBuilder.DeleteData(
                table: "Слово",
                keyColumn: "ID слова",
                keyValue: new Guid("d8381738-6668-4dc1-b735-a97ca50dfbc8"));

            migrationBuilder.DropColumn(
                name: "Путь до аудио",
                table: "Словарная статья");

            migrationBuilder.DropColumn(
                name: "Путь до изображения",
                table: "Словарная статья");

            migrationBuilder.DropColumn(
                name: "Путь до аудио",
                table: "Правка");

            migrationBuilder.DropColumn(
                name: "Путь до изображения",
                table: "Правка");

            migrationBuilder.AlterColumn<Guid>(
                name: "ID слова",
                table: "Слово",
                nullable: false,
                defaultValue: new Guid("e9247265-7f3e-432c-837f-9679e11d6cf5"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("c8d41019-1fdc-4429-8cd1-802e85c59d70"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID статьи",
                table: "Словарная статья",
                nullable: false,
                defaultValue: new Guid("c7267621-154d-4e44-ab34-ab141d795ce3"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("c4260e12-bc8b-4db4-bb3e-f5f9bf352440"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID правки",
                table: "Правка",
                nullable: false,
                defaultValue: new Guid("45e91cf8-6f99-44e1-a83b-a773028a4a7e"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("5e8cc784-3d1c-46e5-a4ea-a16a80bab331"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID пользователя",
                table: "Пользователь",
                nullable: false,
                defaultValue: new Guid("221db561-24a7-4dc1-ab9a-a610aefdb28e"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("6e213662-1dd8-4b17-ad17-9df1c426f5c5"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID назначенного модератора",
                table: "Назначенный модератор",
                nullable: false,
                defaultValue: new Guid("ed343975-1472-4363-9c62-f8c0bf21ff0a"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("fe20627d-23d2-4c9a-962c-72c08cbbb2cc"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 3, 20, 51, 51, 402, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 3, 21, 27, 25, 360, DateTimeKind.Local));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID комментария",
                table: "Комментарий",
                nullable: false,
                defaultValue: new Guid("f22938ba-445f-43b5-be5a-95b49329f5ac"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("08f919d1-a854-44a6-9822-38d637af36f6"));

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[] { new Guid("ee0f006b-101b-4dfc-8610-94f0ed17da0c"), "Тепло" });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[] { new Guid("dac65a36-cffd-4334-96db-a0b0d8bfe82c"), "Холодно" });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[] { new Guid("3b0f6400-7fed-4fd0-bb52-3d1b0af7d69a"), "Лес" });
        }
    }
}
