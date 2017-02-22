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
        public ISpecialization Specialization { get; set; }
        public Weapon Weapon { get; set; }
        public int PhysicalAttack { get; set; }
        public int PhysicalDefense { get; set; }
        public int MagicalAttack { get; set; }
        public int MagicalDefense { get; set; }
        public int Speed { get; set; }
        public int Currency { get; set; }

        public IArea Location { get; set; }

        public Player(string name)
        {
            Name = name;
            Health = 20;
            PhysicalAttack = 5;
            PhysicalDefense = 5;
            MagicalAttack = 5;
            MagicalDefense = 5;
            Speed = 5;
            Weapon = new Weapon("Iron Sword", 5);
            Currency = 5;
        }

        public int ChooseBattleAction()
        {
            bool validAction = false;
            string input;

            do
            {
                Console.WriteLine("1. Attack");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        validAction = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input..");
                        Console.ReadLine();
                        break;
                }
            } while (!validAction);

            return int.Parse(input);
        }
    }
}
