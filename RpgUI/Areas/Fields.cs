using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGLib;

namespace RPGUI.Areas
{
    class Fields : IArea
    {
        public List<IArea> AreaConnections { get; set; }
        public string Name { get; set; }
        public AreaType AreaType { get; set; }
    }
}
