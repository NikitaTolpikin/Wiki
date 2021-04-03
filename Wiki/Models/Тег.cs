using System;
using System.Collections.Generic;

namespace Wiki
{
    public partial class Тег
    {
        public Тег()
        {
            СловарнаяСтатьяТег = new HashSet<СловарнаяСтатьяТег>();
        }

        public long КодТега { get; set; }
        public string Название { get; set; }

        public ICollection<СловарнаяСтатьяТег> СловарнаяСтатьяТег { get; set; }
    }
}
