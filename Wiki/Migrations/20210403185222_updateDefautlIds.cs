using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wiki.Migrations
{
    public partial class updateDefautlIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "ID слова",
                table: "Слово",
                nullable: false,
                defaultValueSql: "(newid())",
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("c8d41019-1fdc-4429-8cd1-802e85c59d70"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID статьи",
                table: "Словарная статья",
                nullable: false,
                defaultValueSql: "(newid())",
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("c4260e12-bc8b-4db4-bb3e-f5f9bf352440"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID правки",
                table: "Правка",
                nullable: false,
                defaultValueSql: "(newid())",
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("5e8cc784-3d1c-46e5-a4ea-a16a80bab331"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID пользователя",
                table: "Пользователь",
                nullable: false,
                defaultValueSql: "(newid())",
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("6e213662-1dd8-4b17-ad17-9df1c426f5c5"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID назначенного модератора",
                table: "Назначенный модератор",
                nullable: false,
                defaultValueSql: "(newid())",
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("fe20627d-23d2-4c9a-962c-72c08cbbb2cc"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 4, 1, 52, 21, 897, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 3, 21, 27, 25, 360, DateTimeKind.Local));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID комментария",
                table: "Комментарий",
                nullable: false,
                defaultValueSql: "(newid())",
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("08f919d1-a854-44a6-9822-38d637af36f6"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "ID слова",
                table: "Слово",
                nullable: false,
                defaultValue: new Guid("c8d41019-1fdc-4429-8cd1-802e85c59d70"),
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "(newid())");

            migrationBuilder.AlterColumn<Guid>(
                name: "ID статьи",
                table: "Словарная статья",
                nullable: false,
                defaultValue: new Guid("c4260e12-bc8b-4db4-bb3e-f5f9bf352440"),
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "(newid())");

            migrationBuilder.AlterColumn<Guid>(
                name: "ID правки",
                table: "Правка",
                nullable: false,
                defaultValue: new Guid("5e8cc784-3d1c-46e5-a4ea-a16a80bab331"),
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "(newid())");

            migrationBuilder.AlterColumn<Guid>(
                name: "ID пользователя",
                table: "Пользователь",
                nullable: false,
                defaultValue: new Guid("6e213662-1dd8-4b17-ad17-9df1c426f5c5"),
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "(newid())");

            migrationBuilder.AlterColumn<Guid>(
                name: "ID назначенного модератора",
                table: "Назначенный модератор",
                nullable: false,
                defaultValue: new Guid("fe20627d-23d2-4c9a-962c-72c08cbbb2cc"),
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "(newid())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Время написания",
                table: "Комментарий",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 3, 21, 27, 25, 360, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 4, 1, 52, 21, 897, DateTimeKind.Local));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID комментария",
                table: "Комментарий",
                nullable: false,
                defaultValue: new Guid("08f919d1-a854-44a6-9822-38d637af36f6"),
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "(newid())");

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
    }
}
