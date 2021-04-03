using System;
using System.Collections.Generic;

namespace Wiki
{
    public partial class СловарнаяСтатьяТег
    {
        public Guid IdСтатьи { get; set; }
        public long КодТега { get; set; }

        public СловарнаяСтатья IdСтатьиNavigation { get; set; }
        public Тег КодТегаNavigation { get; set; }
    }
}
