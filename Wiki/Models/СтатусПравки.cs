using System;
using System.Collections.Generic;

namespace Wiki
{
    public partial class СтатусПравки
    {
        public СтатусПравки()
        {
            Правка = new HashSet<Правка>();
        }

        public long КодСтатуса { get; set; }
        public string Название { get; set; }

        public ICollection<Правка> Правка { get; set; }
    }
}
