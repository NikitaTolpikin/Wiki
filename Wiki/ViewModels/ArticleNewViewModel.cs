using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wiki.ViewModels
{
    public class ArticleNewViewModel
    {
        public string ТекстСтатьи { get; set; }
        public string Название { get; set; }
        public long КодЧастиРечи { get; set; }
        public string СтрокаТегов { get; set; }
    }
}
