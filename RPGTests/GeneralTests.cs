using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGLib;
using RPGLib.Enemies;

namespace RPGTests
{
    [TestClass]
    public class GeneralTests
    {
        Player player;

        [TestInitialize]
        public void Setup()
        {
            player = new Player("Hero");
        }

        [TestMethod]
        public void BattleTest()
        {
            Battle battle = new Battle(player);
            ICreature goblin = new Goblin();
        }
    }
}
