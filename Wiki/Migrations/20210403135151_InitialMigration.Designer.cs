﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wiki.Models;

namespace Wiki.Migrations
{
    [DbContext(typeof(ВикисловарьContext))]
    [Migration("20210403135151_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wiki.КатегорияПользователя", b =>
                {
                    b.Property<long>("КодКатегории")
                        .HasColumnName("Код категории");

                    b.Property<string>("Название")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("КодКатегории");

                    b.ToTable("Категория пользователя");

                    b.HasData(
                        new { КодКатегории = 0L, Название = "Пользователь" },
                        new { КодКатегории = 1L, Название = "Модератор" },
                        new { КодКатегории = 2L, Название = "Администратор" }
                    );
                });

            modelBuilder.Entity("Wiki.Комментарий", b =>
                {
                    b.Property<Guid>("IdКомментария")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID комментария")
                        .HasDefaultValue(new Guid("f22938ba-445f-43b5-be5a-95b49329f5ac"));

                    b.Property<Guid>("IdПользователя")
                        .HasColumnName("ID пользователя");

                    b.Property<Guid>("IdПравки")
                        .HasColumnName("ID правки");

                    b.Property<DateTime>("ВремяНаписания")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Время написания")
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2021, 4, 3, 20, 51, 51, 402, DateTimeKind.Local));

                    b.Property<string>("ТекстКомментария")
                        .IsRequired()
                        .HasColumnName("Текст комментария")
                        .HasColumnType("text");

                    b.HasKey("IdКомментария");

                    b.HasIndex("IdПользователя")
                        .HasName("IX_Автор комментария");

                    b.HasIndex("IdПравки")
                        .HasName("IX_Комментарий к правке");

                    b.ToTable("Комментарий");
                });

            modelBuilder.Entity("Wiki.НазначенныйМодератор", b =>
                {
                    b.Property<Guid>("IdНазначенногоМодератора")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID назначенного модератора")
                        .HasDefaultValue(new Guid("ed343975-1472-4363-9c62-f8c0bf21ff0a"));

                    b.Property<Guid>("IdПользователя")
                        .HasColumnName("ID пользователя");

                    b.Property<Guid>("IdСтатьи")
                        .HasColumnName("ID статьи");

                    b.Property<DateTime>("ДатаНазначения")
                        .HasColumnName("Дата назначения")
                        .HasColumnType("date");

                    b.HasKey("IdНазначенногоМодератора");

                    b.HasIndex("IdПользователя")
                        .HasName("IX_Несколько статей для модератора");

                    b.HasIndex("IdСтатьи")
                        .HasName("IX_Несколько модераторов для статьи");

                    b.ToTable("Назначенный модератор");
                });

            modelBuilder.Entity("Wiki.Пользователь", b =>
                {
                    b.Property<Guid>("IdПользователя")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID пользователя")
                        .HasDefaultValue(new Guid("221db561-24a7-4dc1-ab9a-a610aefdb28e"));

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnName("e-mail")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<DateTime>("ДатаРегистрации")
                        .HasColumnName("Дата регистрации")
                        .HasColumnType("date");

                    b.Property<DateTime>("ДатаРождения")
                        .HasColumnName("Дата рождения")
                        .HasColumnType("date");

                    b.Property<string>("Имя")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<long>("КодКатегории")
                        .HasColumnName("Код категории");

                    b.Property<string>("Отчество")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Пароль")
                        .IsRequired()
                        .HasColumnName("Пароль")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<bool>("Пол");

                    b.Property<string>("Фамилия")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdПользователя");

                    b.HasIndex("КодКатегории")
                        .HasName("IX_Котегория");

                    b.ToTable("Пользователь");
                });

            modelBuilder.Entity("Wiki.Правка", b =>
                {
                    b.Property<Guid>("IdПравки")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID правки")
                        .HasDefaultValue(new Guid("45e91cf8-6f99-44e1-a83b-a773028a4a7e"));

                    b.Property<Guid?>("IdНазначенногоМодератора")
                        .HasColumnName("ID назначенного модератора");

                    b.Property<Guid>("IdПользователя")
                        .HasColumnName("ID пользователя");

                    b.Property<Guid>("IdСтатьи")
                        .HasColumnName("ID статьи");

                    b.Property<DateTime>("ДатаИзмененияСтатуса")
                        .HasColumnName("Дата изменения статуса")
                        .HasColumnType("date");

                    b.Property<DateTime>("ДатаСоздания")
                        .HasColumnName("Дата создания")
                        .HasColumnType("date");

                    b.Property<long>("КодСтатуса")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Код статуса")
                        .HasDefaultValue(0L);

                    b.Property<long>("КодЧастиРечи")
                        .HasColumnName("Код части речи");

                    b.Property<string>("Название")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("ТекстСтатьи")
                        .IsRequired()
                        .HasColumnName("Текст статьи")
                        .HasColumnType("text");

                    b.HasKey("IdПравки");

                    b.HasIndex("IdНазначенногоМодератора")
                        .HasName("IX_Назначенный модератор проверяет правки");

                    b.HasIndex("IdПользователя")
                        .HasName("IX_Автор правки");

                    b.HasIndex("IdСтатьи")
                        .HasName("IX_Все правки для статьи");

                    b.HasIndex("КодСтатуса")
                        .HasName("IX_Статусы правки");

                    b.HasIndex("КодЧастиРечи")
                        .HasName("IX_Часть речи в правке");

                    b.ToTable("Правка");
                });

            modelBuilder.Entity("Wiki.СловарнаяСтатья", b =>
                {
                    b.Property<Guid>("IdСтатьи")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID статьи")
                        .HasDefaultValue(new Guid("c7267621-154d-4e44-ab34-ab141d795ce3"));

                    b.Property<Guid>("IdСлова")
                        .HasColumnName("ID слова");

                    b.Property<long>("КодЧастиРечи")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Код части речи")
                        .HasDefaultValue(0L);

                    b.Property<string>("Название")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<bool>("СтатьяГотова")
                        .HasColumnName("Статья готова");

                    b.Property<string>("ТекстСтатьи")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Текст статьи")
                        .HasColumnType("text")
                        .HasDefaultValue("Статья в разработке");

                    b.HasKey("IdСтатьи");

                    b.HasIndex("IdСлова")
                        .HasName("IX_Статьи для слова");

                    b.HasIndex("КодЧастиРечи")
                        .HasName("IX_Часть речи в статье");

                    b.ToTable("Словарная статья");
                });

            modelBuilder.Entity("Wiki.СловарнаяСтатьяТег", b =>
                {
                    b.Property<Guid>("IdСтатьи")
                        .HasColumnName("ID статьи");

                    b.Property<long>("КодТега")
                        .HasColumnName("Код тега");

                    b.HasKey("IdСтатьи", "КодТега");

                    b.HasIndex("КодТега");

                    b.ToTable("Словарная статья_Тег");
                });

            modelBuilder.Entity("Wiki.Слово", b =>
                {
                    b.Property<Guid>("IdСлова")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID слова")
                        .HasDefaultValue(new Guid("e9247265-7f3e-432c-837f-9679e11d6cf5"));

                    b.Property<string>("Название")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdСлова");

                    b.ToTable("Слово");

                    b.HasData(
                        new { IdСлова = new Guid("ee0f006b-101b-4dfc-8610-94f0ed17da0c"), Название = "Тепло" },
                        new { IdСлова = new Guid("dac65a36-cffd-4334-96db-a0b0d8bfe82c"), Название = "Холодно" },
                        new { IdСлова = new Guid("3b0f6400-7fed-4fd0-bb52-3d1b0af7d69a"), Название = "Лес" }
                    );
                });

            modelBuilder.Entity("Wiki.СтатусПравки", b =>
                {
                    b.Property<long>("КодСтатуса")
                        .HasColumnName("Код статуса");

                    b.Property<string>("Название")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("КодСтатуса");

                    b.ToTable("Статус правки");

                    b.HasData(
                        new { КодСтатуса = 0L, Название = "Не проверено" },
                        new { КодСтатуса = 1L, Название = "Обсуждение" },
                        new { КодСтатуса = 2L, Название = "Принято" },
                        new { КодСтатуса = 3L, Название = "Отклонено" }
                    );
                });

            modelBuilder.Entity("Wiki.Тег", b =>
                {
                    b.Property<long>("КодТега")
                        .HasColumnName("Код тега");

                    b.Property<string>("Название")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("КодТега");

                    b.ToTable("Тег");

                    b.HasData(
                        new { КодТега = 0L, Название = "Физика" },
                        new { КодТега = 1L, Название = "Химия" },
                        new { КодТега = 2L, Название = "Биология" }
                    );
                });

            modelBuilder.Entity("Wiki.ЧастьРечи", b =>
                {
                    b.Property<long>("КодЧастиРечи")
                        .HasColumnName("Код части речи");

                    b.Property<string>("Название")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("КодЧастиРечи");

                    b.ToTable("Часть речи");

                    b.HasData(
                        new { КодЧастиРечи = 0L, Название = "Существительное" },
                        new { КодЧастиРечи = 1L, Название = "Прилагательное" },
                        new { КодЧастиРечи = 2L, Название = "Глагол" },
                        new { КодЧастиРечи = 3L, Название = "Наречие" },
                        new { КодЧастиРечи = 4L, Название = "Местоимение" },
                        new { КодЧастиРечи = 5L, Название = "Числительное" },
                        new { КодЧастиРечи = 6L, Название = "Причастие" },
                        new { КодЧастиРечи = 7L, Название = "Деепричастие" },
                        new { КодЧастиРечи = 8L, Название = "Категория состояния" }
                    );
                });

            modelBuilder.Entity("Wiki.Комментарий", b =>
                {
                    b.HasOne("Wiki.Пользователь", "IdПользователяNavigation")
                        .WithMany("Комментарий")
                        .HasForeignKey("IdПользователя")
                        .HasConstraintName("Автор комментария");

                    b.HasOne("Wiki.Правка", "IdПравкиNavigation")
                        .WithMany("Комментарий")
                        .HasForeignKey("IdПравки")
                        .HasConstraintName("Комментарий к правке");
                });

            modelBuilder.Entity("Wiki.НазначенныйМодератор", b =>
                {
                    b.HasOne("Wiki.Пользователь", "IdПользователяNavigation")
                        .WithMany("НазначенныйМодератор")
                        .HasForeignKey("IdПользователя")
                        .HasConstraintName("Несколько статей для модератора");

                    b.HasOne("Wiki.СловарнаяСтатья", "IdСтатьиNavigation")
                        .WithMany("НазначенныйМодератор")
                        .HasForeignKey("IdСтатьи")
                        .HasConstraintName("Несколько модераторов для статьи");
                });

            modelBuilder.Entity("Wiki.Пользователь", b =>
                {
                    b.HasOne("Wiki.КатегорияПользователя", "КодКатегорииNavigation")
                        .WithMany("Пользователь")
                        .HasForeignKey("КодКатегории")
                        .HasConstraintName("Котегория");
                });

            modelBuilder.Entity("Wiki.Правка", b =>
                {
                    b.HasOne("Wiki.НазначенныйМодератор", "IdНазначенногоМодератораNavigation")
                        .WithMany("Правка")
                        .HasForeignKey("IdНазначенногоМодератора")
                        .HasConstraintName("Назначенный модератор проверяет правки");

                    b.HasOne("Wiki.Пользователь", "IdПользователяNavigation")
                        .WithMany("Правка")
                        .HasForeignKey("IdПользователя")
                        .HasConstraintName("Автор правки");

                    b.HasOne("Wiki.СловарнаяСтатья", "IdСтатьиNavigation")
                        .WithMany("Правка")
                        .HasForeignKey("IdСтатьи")
                        .HasConstraintName("Все правки для статьи");

                    b.HasOne("Wiki.СтатусПравки", "КодСтатусаNavigation")
                        .WithMany("Правка")
                        .HasForeignKey("КодСтатуса")
                        .HasConstraintName("Статусы правки");

                    b.HasOne("Wiki.ЧастьРечи", "КодЧастиРечиNavigation")
                        .WithMany("Правка")
                        .HasForeignKey("КодЧастиРечи")
                        .HasConstraintName("Часть речи в правке");
                });

            modelBuilder.Entity("Wiki.СловарнаяСтатья", b =>
                {
                    b.HasOne("Wiki.Слово", "IdСловаNavigation")
                        .WithMany("СловарнаяСтатья")
                        .HasForeignKey("IdСлова")
                        .HasConstraintName("Статьи для слова");

                    b.HasOne("Wiki.ЧастьРечи", "КодЧастиРечиNavigation")
                        .WithMany("СловарнаяСтатья")
                        .HasForeignKey("КодЧастиРечи")
                        .HasConstraintName("Часть речи в статье");
                });

            modelBuilder.Entity("Wiki.СловарнаяСтатьяТег", b =>
                {
                    b.HasOne("Wiki.СловарнаяСтатья", "IdСтатьиNavigation")
                        .WithMany("СловарнаяСтатьяТег")
                        .HasForeignKey("IdСтатьи")
                        .HasConstraintName("FK_Словарная статья_Тег_Словарная статья");

                    b.HasOne("Wiki.Тег", "КодТегаNavigation")
                        .WithMany("СловарнаяСтатьяТег")
                        .HasForeignKey("КодТега")
                        .HasConstraintName("FK_Словарная статья_Тег_Тег");
                });
#pragma warning restore 612, 618
        }
    }
}