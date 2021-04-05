using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wiki.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Категория пользователя",
                columns: table => new
                {
                    Кодкатегории = table.Column<long>(name: "Код категории", nullable: false),
                    Название = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Категория пользователя", x => x.Кодкатегории);
                });

            migrationBuilder.CreateTable(
                name: "Слово",
                columns: table => new
                {
                    IDслова = table.Column<Guid>(name: "ID слова", nullable: false, defaultValueSql: "newid()"),
                    Название = table.Column<string>(maxLength: 30, nullable: false)
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
                    Название = table.Column<string>(maxLength: 30, nullable: false)
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
                    Название = table.Column<string>(maxLength: 30, nullable: false)
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
                    Название = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Часть речи", x => x.Кодчастиречи);
                });

            migrationBuilder.CreateTable(
                name: "Пользователь",
                columns: table => new
                {
                    IDпользователя = table.Column<Guid>(name: "ID пользователя", nullable: false, defaultValueSql: "newid()"),
                    email = table.Column<string>(name: "e-mail", maxLength: 30, nullable: false),
                    Пароль = table.Column<string>(maxLength: 30, nullable: false),
                    Датарождения = table.Column<DateTime>(name: "Дата рождения", type: "date", nullable: false),
                    Фамилия = table.Column<string>(maxLength: 30, nullable: false),
                    Имя = table.Column<string>(maxLength: 30, nullable: false),
                    Отчество = table.Column<string>(maxLength: 30, nullable: false),
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
                    IDстатьи = table.Column<Guid>(name: "ID статьи", nullable: false, defaultValueSql: "newid()"),
                    Название = table.Column<string>(maxLength: 30, nullable: false),
                    Текстстатьи = table.Column<string>(name: "Текст статьи", type: "text", nullable: false, defaultValue: "Статья в разработке"),
                    Путьдоизображения = table.Column<string>(name: "Путь до изображения", type: "text", nullable: true),
                    Путьдоаудио = table.Column<string>(name: "Путь до аудио", type: "text", nullable: true),
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
                    IDназначенногомодератора = table.Column<Guid>(name: "ID назначенного модератора", nullable: false, defaultValueSql: "newid()"),
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
                    IDправки = table.Column<Guid>(name: "ID правки", nullable: false, defaultValueSql: "newid()"),
                    Датасоздания = table.Column<DateTime>(name: "Дата создания", type: "date", nullable: false),
                    Название = table.Column<string>(maxLength: 30, nullable: false),
                    Текстстатьи = table.Column<string>(name: "Текст статьи", type: "text", nullable: false),
                    Путьдоизображения = table.Column<string>(name: "Путь до изображения", type: "text", nullable: true),
                    Путьдоаудио = table.Column<string>(name: "Путь до аудио", type: "text", nullable: true),
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
                    IDкомментария = table.Column<Guid>(name: "ID комментария", nullable: false, defaultValueSql: "newid()"),
                    Тексткомментария = table.Column<string>(name: "Текст комментария", type: "text", nullable: false),
                    IDправки = table.Column<Guid>(name: "ID правки", nullable: false),
                    IDпользователя = table.Column<Guid>(name: "ID пользователя", nullable: false),
                    Времянаписания = table.Column<DateTime>(name: "Время написания", type: "datetime", nullable: false, defaultValue: new DateTime(2021, 4, 5, 20, 17, 9, 176, DateTimeKind.Local))
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
                    { new Guid("88038bd4-567f-4a62-b13d-516a02e97903"), "Тепло" },
                    { new Guid("2df388d8-44c2-4e5e-bec1-6f479e5a327f"), "Холодно" },
                    { new Guid("9faf6a05-5e0c-414d-8171-9ddcd33185bd"), "Лес" }
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

            migrationBuilder.InsertData(
                table: "Пользователь",
                columns: new[] { "ID пользователя", "e-mail", "Дата регистрации", "Дата рождения", "Имя", "Код категории", "Отчество", "Пароль", "Пол", "Фамилия" },
                values: new object[] { new Guid("9625f0f3-b1fe-4381-9688-866916237b98"), "admin@admin.com", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", 2L, "Admin", "admin", true, "Admin" });

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
