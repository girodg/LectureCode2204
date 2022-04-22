using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL.Tests
{
    [TestClass()]
    public class FantasyWeaponTests
    {
        [TestMethod()]
        public void FantasyWeaponTest()
        {

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 500, 100000);

            Assert.AreEqual(WeaponRarity.Legendary, sting.Rarity);
            Assert.AreEqual(100, sting.Level);
            Assert.AreEqual(500, sting.MaxDamage);
            Assert.AreEqual(100000, sting.Cost);

        }
    }
}