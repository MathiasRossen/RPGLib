using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGLib;

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
    }
}
