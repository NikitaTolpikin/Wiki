using System;
using System.Collections.Generic;

namespace Wiki
{
    public partial class ЧастьРечи
    {
        public ЧастьРечи()
        {
            Правка = new HashSet<Правка>();
            СловарнаяСтатья = new HashSet<СловарнаяСтатья>();
        }

        public long КодЧастиРечи { get; set; }
        public string Название { get; set; }

        public ICollection<Правка> Правка { get; set; }
        public ICollection<СловарнаяСтатья> СловарнаяСтатья { get; set; }
    }
}
