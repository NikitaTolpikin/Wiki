using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wiki.ViewModels
{
    public class EditCheckAllViewModel
    {
        public ICollection<Правка> ПравкиНаПроверку { get; set; }
        public ICollection<Правка> ПровененныеПравки { get; set; }
    }
}
