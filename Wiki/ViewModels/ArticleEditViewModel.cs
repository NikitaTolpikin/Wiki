using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wiki.ViewModels
{
    public class ArticleEditViewModel
    {
        public Guid IdСтатьи { get; set; }
        public string Название { get; set; }
        public string ТекстСтатьи { get; set; }

        public long КодЧастиРечи { get; set; }
        public ICollection<СловарнаяСтатьяТег> СловарнаяСтатьяТег { get; set; }    }
}
