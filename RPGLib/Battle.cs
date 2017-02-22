using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLib
{
    public class Battle
    {
        List<ICreature> creaturesInBattle;

        public Battle(Player player)
        {
            creaturesInBattle = new List<ICreature>();
            creaturesInBattle.Add(player);
        }

        public void AddCreature(ICreature creature)
        {
            creaturesInBattle.Add(creature);
        }

        public void PlayRound()
        {
            int battleChoice;

            foreach(ICreature creature in creaturesInBattle)
            {
                battleChoice = creature.ChooseBattleAction();
            }
        }
    }
}
