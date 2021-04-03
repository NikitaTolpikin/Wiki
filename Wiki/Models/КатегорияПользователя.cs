using System;
using System.Collections.Generic;

namespace Wiki
{
    public partial class КатегорияПользователя
    {
        public КатегорияПользователя()
        {
            Пользователь = new HashSet<Пользователь>();
        }

        public long КодКатегории { get; set; }
        public string Название { get; set; }

        public ICollection<Пользователь> Пользователь { get; set; }
    }
}
