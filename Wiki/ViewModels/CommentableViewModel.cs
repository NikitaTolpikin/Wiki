using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wiki.ViewModels
{
    public class CommentableViewModel
    {
        public string ТекстКомментария { get; set; }
        public Guid IdПравки { get; set; }
        public ICollection<Комментарий> ВсеКомментарии { get; set; }
        public string ПредыдущийАдрес { get; set; }
    }
}
