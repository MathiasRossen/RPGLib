using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLib
{
    public interface IShop
    {
        string Name { get; set; }
        List<IItem> Inventory { get; set; }
    }
}
