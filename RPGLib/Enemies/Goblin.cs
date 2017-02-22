using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLib.Enemies
{
    public class Goblin : ICreature
    {
        Random rand;

        public string Name { get; set; }
        public int Health { get; set; }
        public int PhysicalAttack { get; set; }
        public int PhysicalDefense { get; set; }
        public int MagicalAttack { get; set; }
        public int MagicalDefense { get; set; }
        public int Speed { get; set; }
        public int Currency { get; set; }

        public Goblin()
        {
            rand = new Random();

            Name = "Goblin";
            Health = 10;
            PhysicalAttack = 1;
            PhysicalDefense = 1;
            MagicalAttack = 1;
            MagicalDefense = 1;
            Speed = 1;
            Currency = rand.Next(6);
        }

        public int ChooseBattleAction()
        {
            return 1;
        }
    }
}
