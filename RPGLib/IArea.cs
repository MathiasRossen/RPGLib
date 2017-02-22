using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLib
{
    public enum AreaType { Village, Wild }

    public interface IArea
    {
        string Name { get; set; }
        List<IArea> AreaConnections { get; set; }
        AreaType AreaType { get; set; }
    }
}
