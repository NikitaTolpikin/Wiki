using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wiki.ViewModels
{
    public class EditCheckViewModel: CommentableViewModel
    {
        public Правка Правка { get; set; }
        public long КодСтатуса { get; set; }
    }
}
