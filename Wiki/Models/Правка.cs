using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wiki
{
    public partial class Правка
    {
        public Правка()
        {
            Комментарий = new HashSet<Комментарий>();
        }

        public Guid IdПравки { get; set; }
        public DateTime ДатаСоздания { get; set; }
        [Required(ErrorMessage = "Не указано название статьи")]
        public string Название { get; set; }
        [Required(ErrorMessage = "Не указан текст статьи")]
        public string ТекстСтатьи { get; set; }
        public string ПутьДоИзображения { get; set; }
        public string ПутьДоАудио { get; set; }
        public DateTime ДатаИзмененияСтатуса { get; set; }
        public Guid IdСтатьи { get; set; }
        public Guid IdПользователя { get; set; }
        [Required(ErrorMessage = "Не указана часть речи")]
        public long КодЧастиРечи { get; set; }
        public Guid? IdНазначенногоМодератора { get; set; }
        public long КодСтатуса { get; set; }

        public НазначенныйМодератор IdНазначенногоМодератораNavigation { get; set; }
        public Пользователь IdПользователяNavigation { get; set; }
        public СловарнаяСтатья IdСтатьиNavigation { get; set; }
        public СтатусПравки КодСтатусаNavigation { get; set; }
        public ЧастьРечи КодЧастиРечиNavigation { get; set; }
        public ICollection<Комментарий> Комментарий { get; set; }
    }
}
