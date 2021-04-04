using System;
using System.Collections.Generic;

namespace Wiki
{
    public partial class СловарнаяСтатья
    {
        public СловарнаяСтатья()
        {
            НазначенныйМодератор = new HashSet<НазначенныйМодератор>();
            Правка = new HashSet<Правка>();
            СловарнаяСтатьяТег = new HashSet<СловарнаяСтатьяТег>();
        }

        public Guid IdСтатьи { get; set; }
        public string Название { get; set; }
        public string ТекстСтатьи { get; set; }
        public string ПутьДоИзображения { get; set; }
        public string ПутьДоАудио { get; set; }
        public Guid IdСлова { get; set; }
        public long КодЧастиРечи { get; set; }
        public bool СтатьяГотова { get; set; }

        public Слово IdСловаNavigation { get; set; }
        public ЧастьРечи КодЧастиРечиNavigation { get; set; }
        public ICollection<НазначенныйМодератор> НазначенныйМодератор { get; set; }
        public ICollection<Правка> Правка { get; set; }
        public ICollection<СловарнаяСтатьяТег> СловарнаяСтатьяТег { get; set; }
    }
}
