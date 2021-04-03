using System;
using System.Collections.Generic;

namespace Wiki
{
    public partial class НазначенныйМодератор
    {
        public НазначенныйМодератор()
        {
            Правка = new HashSet<Правка>();
        }

        public Guid IdНазначенногоМодератора { get; set; }
        public DateTime ДатаНазначения { get; set; }
        public Guid IdСтатьи { get; set; }
        public Guid IdПользователя { get; set; }

        public Пользователь IdПользователяNavigation { get; set; }
        public СловарнаяСтатья IdСтатьиNavigation { get; set; }
        public ICollection<Правка> Правка { get; set; }
    }
}
