using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalc.Domain;

namespace NumericSequenceCalculator.Tests
{
    [TestClass]
    public class NumericSequenceCalculatorTest
    {
        [TestMethod]
        public void TestS311()
        {
            SequenceCalculator sc = new SequenceCalculator();
            Assert.AreEqual( sc.S311(6), "1,2,3,4,5,6");
        }
        [TestMethod]
        public void TestS312()
        {
            SequenceCalculator sc = new SequenceCalculator();
            Assert.AreEqual(sc.S312(9), "1,3,5,7,9");
        }
        [TestMethod]
        public void TestS313()
        {
            SequenceCalculator sc = new SequenceCalculator();
            Assert.AreEqual(sc.S313(9), "2,4,6,8");
        }
        [TestMethod]
        public void TestS314()
        {
            SequenceCalculator sc = new SequenceCalculator();
            Assert.AreEqual(sc.S314(16), "1,2,C,4,E,C,7,8,C,E,11,C,13,14,Z,16");
        }
        [TestMethod]
        public void TestS315()
        {
            SequenceCalculator sc = new SequenceCalculator();
            Assert.AreEqual(sc.S315(16), "0,1,1,2,3,5,8,13");
        }
    }
}
