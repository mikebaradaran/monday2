using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTestWith2PositiveNumbers()
        {
            Calculator calc = new Calculator();

            int res = calc.Add(1, 2);
            Assert.AreEqual(3, res);
        }

        [TestMethod()]
        public void AddTestWith2NegativeNumbers()
        {
            Calculator calc = new Calculator();

            int res = calc.Add(-100, -2);
            Assert.AreEqual(-102, res);
        }

        [TestMethod()]
        public void AddTestWith2NumbersOneBeingGreaterThan100()
        {
            Calculator calc = new Calculator();

            int res = calc.Add(101, -2);
            Assert.AreEqual(99, res);
        }


        [TestMethod()]
        public void MultiplyTestWith2Numbers()
        {
            Calculator calc = new Calculator();

            int res = calc.Multiply(100, 2);
            Assert.AreEqual(200, res);
        }
    }
}