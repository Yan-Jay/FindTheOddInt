using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindTheOddInt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheOddInt.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void find_itTest()
        {
            var except = 5;
            var actural = Kata.find_it(new[] {20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5});
            Assert.AreEqual(except, actural);
        }
    }
}