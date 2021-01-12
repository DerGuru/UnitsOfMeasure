using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class _ExtensionTests
    {
        [TestMethod]
        public void SameAreEqual()
        {
            var m = new Meter(1);
            Assert.AreEqual(m, m);
        }

        [TestMethod]
        public void SameValuesAreEqual()
        {
            var m = new Meter(1);
            var n = new Meter(1);
            Assert.AreEqual(m, n);
        }

        [TestMethod]
        public void NotSameValuesAreNotEqual()
        {
            var m = new Meter(1);
            var n = new Meter(2);
            Assert.AreNotEqual(m, n);
        }

        [TestMethod]
        public void SameCopareTo0()
        {
            var m = new Meter(1);
            var c = m.CompareTo(m);
            Assert.AreEqual(0,c);
        }

        [TestMethod]
        public void SameValuesCopareTo0()
        {
            var m = new Meter(1);
            var n = new Meter(1);
            var c = m.CompareTo(n);
            Assert.AreEqual(0, c);
        }

        [TestMethod]
        public void NotSameValuesDoNotCopareTo0()
        {
            var m = new Meter(1);
            var n = new Meter(2);
            var c = m.CompareTo(n);
            var d = n.CompareTo(m);

            Assert.AreNotEqual(0, c);
            Assert.AreEqual(-1, c);
            Assert.AreNotEqual(0, d);
            Assert.AreEqual(1, d);
        }
    }

}
