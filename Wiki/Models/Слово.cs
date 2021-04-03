using System;
using System.Collections.Generic;

namespace Wiki
{
    public partial class Слово
    {
        public Слово()
        {
            СловарнаяСтатья = new HashSet<СловарнаяСтатья>();
        }

        public Guid IdСлова { get; set; }
        public string Название { get; set; }

        public ICollection<СловарнаяСтатья> СловарнаяСтатья { get; set; }
    }
}
