using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLib
{
    public interface ICreature
    {
        string Name { get; set; }
        int Health { get; set; }
        int PhysicalAttack { get; set; }
        int PhysicalDefense { get; set; }
        int MagicalAttack { get; set; }
        int MagicalDefense { get; set; }
        int Speed { get; set; }
        int Currency { get; set; }

        int ChooseBattleAction();
    }
}
