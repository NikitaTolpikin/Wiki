using System;
using System.Collections.Generic;

namespace Wiki
{
    public partial class Пользователь
    {
        public Пользователь()
        {
            Комментарий = new HashSet<Комментарий>();
            НазначенныйМодератор = new HashSet<НазначенныйМодератор>();
            Правка = new HashSet<Правка>();
        }

        public Guid IdПользователя { get; set; }
        public string EMail { get; set; }
        public string Пароль { get; set; }
        public DateTime ДатаРождения { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public bool Пол { get; set; }
        public long КодКатегории { get; set; }
        public DateTime ДатаРегистрации { get; set; }

        public КатегорияПользователя КодКатегорииNavigation { get; set; }
        public ICollection<Комментарий> Комментарий { get; set; }
        public ICollection<НазначенныйМодератор> НазначенныйМодератор { get; set; }
        public ICollection<Правка> Правка { get; set; }
    }
}
