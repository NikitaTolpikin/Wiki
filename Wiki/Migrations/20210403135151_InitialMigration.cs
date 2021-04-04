using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wiki.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Категория пользователя",
                columns: table => new
                {
                    Кодкатегории = table.Column<long>(name: "Код категории", nullable: false),
                    Название = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Категория пользователя", x => x.Кодкатегории);
                });

            migrationBuilder.CreateTable(
                name: "Слово",
                columns: table => new
                {
                    IDслова = table.Column<Guid>(name: "ID слова", nullable: false, defaultValue: new Guid("e9247265-7f3e-432c-837f-9679e11d6cf5")),
                    Название = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Слово", x => x.IDслова);
                });

            migrationBuilder.CreateTable(
                name: "Статус правки",
                columns: table => new
                {
                    Кодстатуса = table.Column<long>(name: "Код статуса", nullable: false),
                    Название = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Статус правки", x => x.Кодстатуса);
                });

            migrationBuilder.CreateTable(
                name: "Тег",
                columns: table => new
                {
                    Кодтега = table.Column<long>(name: "Код тега", nullable: false),
                    Название = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Тег", x => x.Кодтега);
                });

            migrationBuilder.CreateTable(
                name: "Часть речи",
                columns: table => new
                {
                    Кодчастиречи = table.Column<long>(name: "Код части речи", nullable: false),
                    Название = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Часть речи", x => x.Кодчастиречи);
                });

            migrationBuilder.CreateTable(
                name: "Пользователь",
                columns: table => new
                {
                    IDпользователя = table.Column<Guid>(name: "ID пользователя", nullable: false, defaultValue: new Guid("221db561-24a7-4dc1-ab9a-a610aefdb28e")),
                    email = table.Column<string>(name: "e-mail", unicode: false, maxLength: 30, nullable: false),
                    Пароль = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Датарождения = table.Column<DateTime>(name: "Дата рождения", type: "date", nullable: false),
                    Фамилия = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Имя = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Отчество = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Пол = table.Column<bool>(nullable: false),
                    Кодкатегории = table.Column<long>(name: "Код категории", nullable: false),
                    Датарегистрации = table.Column<DateTime>(name: "Дата регистрации", type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Пользователь", x => x.IDпользователя);
                    table.ForeignKey(
                        name: "Котегория",
                        column: x => x.Кодкатегории,
                        principalTable: "Категория пользователя",
                        principalColumn: "Код категории",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Словарная статья",
                columns: table => new
                {
                    IDстатьи = table.Column<Guid>(name: "ID статьи", nullable: false, defaultValue: new Guid("c7267621-154d-4e44-ab34-ab141d795ce3")),
                    Название = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Текстстатьи = table.Column<string>(name: "Текст статьи", type: "text", nullable: false, defaultValue: "Статья в разработке"),
                    IDслова = table.Column<Guid>(name: "ID слова", nullable: false),
                    Кодчастиречи = table.Column<long>(name: "Код части речи", nullable: false, defaultValue: 0L),
                    Статьяготова = table.Column<bool>(name: "Статья готова", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Словарная статья", x => x.IDстатьи);
                    table.ForeignKey(
                        name: "Статьи для слова",
                        column: x => x.IDслова,
                        principalTable: "Слово",
                        principalColumn: "ID слова",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Часть речи в статье",
                        column: x => x.Кодчастиречи,
                        principalTable: "Часть речи",
                        principalColumn: "Код части речи",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Назначенный модератор",
                columns: table => new
                {
                    IDназначенногомодератора = table.Column<Guid>(name: "ID назначенного модератора", nullable: false, defaultValue: new Guid("ed343975-1472-4363-9c62-f8c0bf21ff0a")),
                    Датаназначения = table.Column<DateTime>(name: "Дата назначения", type: "date", nullable: false),
                    IDстатьи = table.Column<Guid>(name: "ID статьи", nullable: false),
                    IDпользователя = table.Column<Guid>(name: "ID пользователя", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Назначенный модератор", x => x.IDназначенногомодератора);
                    table.ForeignKey(
                        name: "Несколько статей для модератора",
                        column: x => x.IDпользователя,
                        principalTable: "Пользователь",
                        principalColumn: "ID пользователя",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Несколько модераторов для статьи",
                        column: x => x.IDстатьи,
                        principalTable: "Словарная статья",
                        principalColumn: "ID статьи",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Словарная статья_Тег",
                columns: table => new
                {
                    IDстатьи = table.Column<Guid>(name: "ID статьи", nullable: false),
                    Кодтега = table.Column<long>(name: "Код тега", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Словарная статья_Тег", x => new { x.IDстатьи, x.Кодтега });
                    table.ForeignKey(
                        name: "FK_Словарная статья_Тег_Словарная статья",
                        column: x => x.IDстатьи,
                        principalTable: "Словарная статья",
                        principalColumn: "ID статьи",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Словарная статья_Тег_Тег",
                        column: x => x.Кодтега,
                        principalTable: "Тег",
                        principalColumn: "Код тега",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Правка",
                columns: table => new
                {
                    IDправки = table.Column<Guid>(name: "ID правки", nullable: false, defaultValue: new Guid("45e91cf8-6f99-44e1-a83b-a773028a4a7e")),
                    Датасоздания = table.Column<DateTime>(name: "Дата создания", type: "date", nullable: false),
                    Название = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Текстстатьи = table.Column<string>(name: "Текст статьи", type: "text", nullable: false),
                    Датаизменениястатуса = table.Column<DateTime>(name: "Дата изменения статуса", type: "date", nullable: false),
                    IDстатьи = table.Column<Guid>(name: "ID статьи", nullable: false),
                    IDпользователя = table.Column<Guid>(name: "ID пользователя", nullable: false),
                    Кодчастиречи = table.Column<long>(name: "Код части речи", nullable: false),
                    IDназначенногомодератора = table.Column<Guid>(name: "ID назначенного модератора", nullable: true),
                    Кодстатуса = table.Column<long>(name: "Код статуса", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Правка", x => x.IDправки);
                    table.ForeignKey(
                        name: "Назначенный модератор проверяет правки",
                        column: x => x.IDназначенногомодератора,
                        principalTable: "Назначенный модератор",
                        principalColumn: "ID назначенного модератора",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Автор правки",
                        column: x => x.IDпользователя,
                        principalTable: "Пользователь",
                        principalColumn: "ID пользователя",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Все правки для статьи",
                        column: x => x.IDстатьи,
                        principalTable: "Словарная статья",
                        principalColumn: "ID статьи",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Статусы правки",
                        column: x => x.Кодстатуса,
                        principalTable: "Статус правки",
                        principalColumn: "Код статуса",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Часть речи в правке",
                        column: x => x.Кодчастиречи,
                        principalTable: "Часть речи",
                        principalColumn: "Код части речи",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Комментарий",
                columns: table => new
                {
                    IDкомментария = table.Column<Guid>(name: "ID комментария", nullable: false, defaultValue: new Guid("f22938ba-445f-43b5-be5a-95b49329f5ac")),
                    Тексткомментария = table.Column<string>(name: "Текст комментария", type: "text", nullable: false),
                    IDправки = table.Column<Guid>(name: "ID правки", nullable: false),
                    IDпользователя = table.Column<Guid>(name: "ID пользователя", nullable: false),
                    Времянаписания = table.Column<DateTime>(name: "Время написания", type: "datetime", nullable: false, defaultValue: new DateTime(2021, 4, 3, 20, 51, 51, 402, DateTimeKind.Local))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Комментарий", x => x.IDкомментария);
                    table.ForeignKey(
                        name: "Автор комментария",
                        column: x => x.IDпользователя,
                        principalTable: "Пользователь",
                        principalColumn: "ID пользователя",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Комментарий к правке",
                        column: x => x.IDправки,
                        principalTable: "Правка",
                        principalColumn: "ID правки",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Категория пользователя",
                columns: new[] { "Код категории", "Название" },
                values: new object[,]
                {
                    { 0L, "Пользователь" },
                    { 1L, "Модератор" },
                    { 2L, "Администратор" }
                });

            migrationBuilder.InsertData(
                table: "Слово",
                columns: new[] { "ID слова", "Название" },
                values: new object[,]
                {
                    { new Guid("ee0f006b-101b-4dfc-8610-94f0ed17da0c"), "Тепло" },
                    { new Guid("dac65a36-cffd-4334-96db-a0b0d8bfe82c"), "Холодно" },
                    { new Guid("3b0f6400-7fed-4fd0-bb52-3d1b0af7d69a"), "Лес" }
                });

            migrationBuilder.InsertData(
                table: "Статус правки",
                columns: new[] { "Код статуса", "Название" },
                values: new object[,]
                {
                    { 0L, "Не проверено" },
                    { 1L, "Обсуждение" },
                    { 2L, "Принято" },
                    { 3L, "Отклонено" }
                });

            migrationBuilder.InsertData(
                table: "Тег",
                columns: new[] { "Код тега", "Название" },
                values: new object[,]
                {
                    { 2L, "Биология" },
                    { 0L, "Физика" },
                    { 1L, "Химия" }
                });

            migrationBuilder.InsertData(
                table: "Часть речи",
                columns: new[] { "Код части речи", "Название" },
                values: new object[,]
                {
                    { 7L, "Деепричастие" },
                    { 0L, "Существительное" },
                    { 1L, "Прилагательное" },
                    { 2L, "Глагол" },
                    { 3L, "Наречие" },
                    { 4L, "Местоимение" },
                    { 5L, "Числительное" },
                    { 6L, "Причастие" },
                    { 8L, "Категория состояния" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Автор комментария",
                table: "Комментарий",
                column: "ID пользователя");

            migrationBuilder.CreateIndex(
                name: "IX_Комментарий к правке",
                table: "Комментарий",
                column: "ID правки");

            migrationBuilder.CreateIndex(
                name: "IX_Несколько статей для модератора",
                table: "Назначенный модератор",
                column: "ID пользователя");

            migrationBuilder.CreateIndex(
                name: "IX_Несколько модераторов для статьи",
                table: "Назначенный модератор",
                column: "ID статьи");

            migrationBuilder.CreateIndex(
                name: "IX_Котегория",
                table: "Пользователь",
                column: "Код категории");

            migrationBuilder.CreateIndex(
                name: "IX_Назначенный модератор проверяет правки",
                table: "Правка",
                column: "ID назначенного модератора");

            migrationBuilder.CreateIndex(
                name: "IX_Автор правки",
                table: "Правка",
                column: "ID пользователя");

            migrationBuilder.CreateIndex(
                name: "IX_Все правки для статьи",
                table: "Правка",
                column: "ID статьи");

            migrationBuilder.CreateIndex(
                name: "IX_Статусы правки",
                table: "Правка",
                column: "Код статуса");

            migrationBuilder.CreateIndex(
                name: "IX_Часть речи в правке",
                table: "Правка",
                column: "Код части речи");

            migrationBuilder.CreateIndex(
                name: "IX_Статьи для слова",
                table: "Словарная статья",
                column: "ID слова");

            migrationBuilder.CreateIndex(
                name: "IX_Часть речи в статье",
                table: "Словарная статья",
                column: "Код части речи");

            migrationBuilder.CreateIndex(
                name: "IX_Словарная статья_Тег_Код тега",
                table: "Словарная статья_Тег",
                column: "Код тега");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Комментарий");

            migrationBuilder.DropTable(
                name: "Словарная статья_Тег");

            migrationBuilder.DropTable(
                name: "Правка");

            migrationBuilder.DropTable(
                name: "Тег");

            migrationBuilder.DropTable(
                name: "Назначенный модератор");

            migrationBuilder.DropTable(
                name: "Статус правки");

            migrationBuilder.DropTable(
                name: "Пользователь");

            migrationBuilder.DropTable(
                name: "Словарная статья");

            migrationBuilder.DropTable(
                name: "Категория пользователя");

            migrationBuilder.DropTable(
                name: "Слово");

            migrationBuilder.DropTable(
                name: "Часть речи");
        }
    }
}
