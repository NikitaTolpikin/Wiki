using System;

namespace Wiki
{
    public partial class Комментарий
    {
        public Guid IdКомментария { get; set; }
        public string ТекстКомментария { get; set; }
        public Guid IdПравки { get; set; }
        public Guid IdПользователя { get; set; }
        public DateTime ВремяНаписания { get; set; }

        public Пользователь IdПользователяNavigation { get; set; }
        public Правка IdПравкиNavigation { get; set; }
    }
}
