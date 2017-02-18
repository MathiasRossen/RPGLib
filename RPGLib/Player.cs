using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLib
{
    public class Player : ICreature
    {
        public string Name { get; set; }
        public int Health { get; set; }
    }
}
