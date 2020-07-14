using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGame_Assign_F;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_Assign_F.Tests
{
    [TestClass()]
    public class OptionGameTests
    {
        [TestMethod()]
        public void ShootTest()
        {
            OptionGame instance = new OptionGame();
            instance.Shoot();
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void ShootAwayTest()
        {
            OptionGame instance = new OptionGame();
            instance.ShootAway();
            Assert.IsTrue(true);
        }
    }
}