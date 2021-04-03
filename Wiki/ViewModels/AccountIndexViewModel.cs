using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wiki.ViewModels
{
    public class AccountIndexViewModel
    {
        public Пользователь Пользователь { get; set; }
        public ICollection<СловарнаяСтатья> ВсеСтатьи { get; set; }
    }
}
