using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Wiki.Models
{
    public partial class ВикисловарьContext : DbContext
    {
        public ВикисловарьContext()
        {
        }

        public ВикисловарьContext(DbContextOptions<ВикисловарьContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<КатегорияПользователя> КатегорияПользователя { get; set; }
        public virtual DbSet<Комментарий> Комментарий { get; set; }
        public virtual DbSet<НазначенныйМодератор> НазначенныйМодератор { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }
        public virtual DbSet<Правка> Правка { get; set; }
        public virtual DbSet<СловарнаяСтатья> СловарнаяСтатья { get; set; }
        public virtual DbSet<СловарнаяСтатьяТег> СловарнаяСтатьяТег { get; set; }
        public virtual DbSet<Слово> Слово { get; set; }
        public virtual DbSet<СтатусПравки> СтатусПравки { get; set; }
        public virtual DbSet<Тег> Тег { get; set; }
        public virtual DbSet<ЧастьРечи> ЧастьРечи { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<КатегорияПользователя>(entity =>
            {
                entity.HasKey(e => e.КодКатегории);

                entity.ToTable("Категория пользователя");

                entity.Property(e => e.КодКатегории)
                    .HasColumnName("Код категории")
                    .ValueGeneratedNever();

                entity.Property(e => e.Название)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Комментарий>(entity =>
            {
                entity.HasKey(e => e.IdКомментария);

                entity.HasIndex(e => e.IdПользователя)
                    .HasName("IX_Автор комментария");

                entity.HasIndex(e => e.IdПравки)
                    .HasName("IX_Комментарий к правке");

                entity.Property(e => e.IdКомментария)
                    .HasColumnName("ID комментария")
                    .HasDefaultValue(Guid.NewGuid());

                entity.Property(e => e.IdПользователя).HasColumnName("ID пользователя");

                entity.Property(e => e.IdПравки).HasColumnName("ID правки");

                entity.Property(e => e.ВремяНаписания)
                    .HasColumnName("Время написания")
                    .HasColumnType("datetime")
                    .HasDefaultValue(DateTime.Now);

                entity.Property(e => e.ТекстКомментария)
                    .IsRequired()
                    .HasColumnName("Текст комментария")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdПользователяNavigation)
                    .WithMany(p => p.Комментарий)
                    .HasForeignKey(d => d.IdПользователя)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Автор комментария");

                entity.HasOne(d => d.IdПравкиNavigation)
                    .WithMany(p => p.Комментарий)
                    .HasForeignKey(d => d.IdПравки)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Комментарий к правке");
            });

            modelBuilder.Entity<НазначенныйМодератор>(entity =>
            {
                entity.HasKey(e => e.IdНазначенногоМодератора);

                entity.ToTable("Назначенный модератор");

                entity.HasIndex(e => e.IdПользователя)
                    .HasName("IX_Несколько статей для модератора");

                entity.HasIndex(e => e.IdСтатьи)
                    .HasName("IX_Несколько модераторов для статьи");

                entity.Property(e => e.IdНазначенногоМодератора)
                    .HasColumnName("ID назначенного модератора")
                    .HasDefaultValue(Guid.NewGuid());

                entity.Property(e => e.IdПользователя).HasColumnName("ID пользователя");

                entity.Property(e => e.IdСтатьи).HasColumnName("ID статьи");

                entity.Property(e => e.ДатаНазначения)
                    .HasColumnName("Дата назначения")
                    .HasColumnType("date");

                entity.HasOne(d => d.IdПользователяNavigation)
                    .WithMany(p => p.НазначенныйМодератор)
                    .HasForeignKey(d => d.IdПользователя)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Несколько статей для модератора");

                entity.HasOne(d => d.IdСтатьиNavigation)
                    .WithMany(p => p.НазначенныйМодератор)
                    .HasForeignKey(d => d.IdСтатьи)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Несколько модераторов для статьи");
            });

            modelBuilder.Entity<Пользователь>(entity =>
            {
                entity.HasKey(e => e.IdПользователя);

                entity.HasIndex(e => e.КодКатегории)
                    .HasName("IX_Котегория");

                entity.Property(e => e.IdПользователя)
                    .HasColumnName("ID пользователя")
                    .HasDefaultValue(Guid.NewGuid());

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("e-mail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Пароль)
                    .IsRequired()
                    .HasColumnName("Пароль")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ДатаРегистрации)
                    .HasColumnName("Дата регистрации")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаРождения)
                    .HasColumnName("Дата рождения")
                    .HasColumnType("date");

                entity.Property(e => e.Имя)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.КодКатегории).HasColumnName("Код категории");

                entity.Property(e => e.Отчество)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Фамилия)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.КодКатегорииNavigation)
                    .WithMany(p => p.Пользователь)
                    .HasForeignKey(d => d.КодКатегории)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Котегория");
            });

            modelBuilder.Entity<Правка>(entity =>
            {
                entity.HasKey(e => e.IdПравки);

                entity.HasIndex(e => e.IdНазначенногоМодератора)
                    .HasName("IX_Назначенный модератор проверяет правки");

                entity.HasIndex(e => e.IdПользователя)
                    .HasName("IX_Автор правки");

                entity.HasIndex(e => e.IdСтатьи)
                    .HasName("IX_Все правки для статьи");

                entity.HasIndex(e => e.КодСтатуса)
                    .HasName("IX_Статусы правки");

                entity.HasIndex(e => e.КодЧастиРечи)
                    .HasName("IX_Часть речи в правке");

                entity.Property(e => e.IdПравки)
                    .HasColumnName("ID правки")
                    .HasDefaultValue(Guid.NewGuid());

                entity.Property(e => e.IdНазначенногоМодератора).HasColumnName("ID назначенного модератора");

                entity.Property(e => e.IdПользователя).HasColumnName("ID пользователя");

                entity.Property(e => e.IdСтатьи).HasColumnName("ID статьи");

                entity.Property(e => e.ДатаИзмененияСтатуса)
                    .HasColumnName("Дата изменения статуса")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаСоздания)
                    .HasColumnName("Дата создания")
                    .HasColumnType("date");

                entity.Property(e => e.КодСтатуса).HasColumnName("Код статуса").HasDefaultValue(0); ;

                entity.Property(e => e.КодЧастиРечи).HasColumnName("Код части речи");

                entity.Property(e => e.Название)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ТекстСтатьи)
                    .IsRequired()
                    .HasColumnName("Текст статьи")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdНазначенногоМодератораNavigation)
                    .WithMany(p => p.Правка)
                    .HasForeignKey(d => d.IdНазначенногоМодератора)
                    .HasConstraintName("Назначенный модератор проверяет правки");

                entity.HasOne(d => d.IdПользователяNavigation)
                    .WithMany(p => p.Правка)
                    .HasForeignKey(d => d.IdПользователя)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Автор правки");

                entity.HasOne(d => d.IdСтатьиNavigation)
                    .WithMany(p => p.Правка)
                    .HasForeignKey(d => d.IdСтатьи)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Все правки для статьи");

                entity.HasOne(d => d.КодСтатусаNavigation)
                    .WithMany(p => p.Правка)
                    .HasForeignKey(d => d.КодСтатуса)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Статусы правки");

                entity.HasOne(d => d.КодЧастиРечиNavigation)
                    .WithMany(p => p.Правка)
                    .HasForeignKey(d => d.КодЧастиРечи)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Часть речи в правке");
            });

            modelBuilder.Entity<СловарнаяСтатья>(entity =>
            {
                entity.HasKey(e => e.IdСтатьи);

                entity.ToTable("Словарная статья");

                entity.HasIndex(e => e.IdСлова)
                    .HasName("IX_Статьи для слова");

                entity.HasIndex(e => e.КодЧастиРечи)
                    .HasName("IX_Часть речи в статье");

                entity.Property(e => e.IdСтатьи)
                    .HasColumnName("ID статьи")
                    .HasDefaultValue(Guid.NewGuid());

                entity.Property(e => e.IdСлова).HasColumnName("ID слова");

                entity.Property(e => e.КодЧастиРечи).HasColumnName("Код части речи").HasDefaultValue(0);

                entity.Property(e => e.СтатьяГотова).HasColumnName("Статья готова");

                entity.Property(e => e.Название)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ТекстСтатьи)
                    .IsRequired()
                    .HasColumnName("Текст статьи")
                    .HasColumnType("text")
                    .HasDefaultValue("Статья в разработке");

                entity.HasOne(d => d.IdСловаNavigation)
                    .WithMany(p => p.СловарнаяСтатья)
                    .HasForeignKey(d => d.IdСлова)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Статьи для слова");

                entity.HasOne(d => d.КодЧастиРечиNavigation)
                    .WithMany(p => p.СловарнаяСтатья)
                    .HasForeignKey(d => d.КодЧастиРечи)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Часть речи в статье");
            });

            modelBuilder.Entity<СловарнаяСтатьяТег>(entity =>
            {
                entity.HasKey(e => new { e.IdСтатьи, e.КодТега });

                entity.ToTable("Словарная статья_Тег");

                entity.Property(e => e.IdСтатьи).HasColumnName("ID статьи");

                entity.Property(e => e.КодТега).HasColumnName("Код тега");

                entity.HasOne(d => d.IdСтатьиNavigation)
                    .WithMany(p => p.СловарнаяСтатьяТег)
                    .HasForeignKey(d => d.IdСтатьи)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Словарная статья_Тег_Словарная статья");

                entity.HasOne(d => d.КодТегаNavigation)
                    .WithMany(p => p.СловарнаяСтатьяТег)
                    .HasForeignKey(d => d.КодТега)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Словарная статья_Тег_Тег");
            });

            modelBuilder.Entity<Слово>(entity =>
            {
                entity.HasKey(e => e.IdСлова);

                entity.Property(e => e.IdСлова)
                    .HasColumnName("ID слова")
                    .HasDefaultValue(Guid.NewGuid());

                entity.Property(e => e.Название)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<СтатусПравки>(entity =>
            {
                entity.HasKey(e => e.КодСтатуса);

                entity.ToTable("Статус правки");

                entity.Property(e => e.КодСтатуса)
                    .HasColumnName("Код статуса")
                    .ValueGeneratedNever();

                entity.Property(e => e.Название)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Тег>(entity =>
            {
                entity.HasKey(e => e.КодТега);

                entity.Property(e => e.КодТега)
                    .HasColumnName("Код тега")
                    .ValueGeneratedNever();

                entity.Property(e => e.Название)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ЧастьРечи>(entity =>
            {
                entity.HasKey(e => e.КодЧастиРечи);

                entity.ToTable("Часть речи");

                entity.Property(e => e.КодЧастиРечи)
                    .HasColumnName("Код части речи")
                    .ValueGeneratedNever();

                entity.Property(e => e.Название)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<КатегорияПользователя>().HasData(
            new КатегорияПользователя[]
            {
                new КатегорияПользователя { КодКатегории=0, Название="Пользователь"},
                new КатегорияПользователя { КодКатегории=1, Название="Модератор"},
                new КатегорияПользователя { КодКатегории=2, Название="Администратор"},
            });

            modelBuilder.Entity<ЧастьРечи>().HasData(
            new ЧастьРечи[]
            {
                new ЧастьРечи { КодЧастиРечи=0, Название="Существительное"},
                new ЧастьРечи { КодЧастиРечи=1, Название="Прилагательное"},
                new ЧастьРечи { КодЧастиРечи=2, Название="Глагол"},
                new ЧастьРечи { КодЧастиРечи=3, Название="Наречие"},
                new ЧастьРечи { КодЧастиРечи=4, Название="Местоимение"},
                new ЧастьРечи { КодЧастиРечи=5, Название="Числительное"},
                new ЧастьРечи { КодЧастиРечи=6, Название="Причастие"},
                new ЧастьРечи { КодЧастиРечи=7, Название="Деепричастие"},
                new ЧастьРечи { КодЧастиРечи=8, Название="Категория состояния"},
            });

            modelBuilder.Entity<Тег>().HasData(
            new Тег[]
            {
                new Тег { КодТега=0, Название="Физика"},
                new Тег { КодТега=1, Название="Химия"},
                new Тег { КодТега=2, Название="Биология"},
            });

            modelBuilder.Entity<Слово>().HasData(
            new Слово[]
            {
                new Слово { IdСлова=Guid.NewGuid(), Название="Тепло"},
                new Слово { IdСлова=Guid.NewGuid(), Название="Холодно"},
                new Слово { IdСлова=Guid.NewGuid(), Название="Лес"},
            });

            modelBuilder.Entity<СтатусПравки>().HasData(
            new СтатусПравки[]
            {
                new СтатусПравки { КодСтатуса=0, Название="Не проверено"},
                new СтатусПравки { КодСтатуса=1, Название="Обсуждение"},
                new СтатусПравки { КодСтатуса=2, Название="Принято"},
                new СтатусПравки { КодСтатуса=3, Название="Отклонено"},
            });
        }
    }
}
