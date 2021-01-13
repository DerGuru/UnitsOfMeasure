using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Numerics;
using UnitsOfMeasure;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class UnitOfMeasureTests
    {
        [TestMethod]
        public void Hashes()
        {
            HashSet<UnitOfMeasure> hsd = new HashSet<UnitOfMeasure>(new Distance[] { new Meter(1), new KiloMeter(1), new MilliMeter(1000) });
            Assert.AreEqual(2, hsd.Count);
        }

        [TestMethod]
        public void Add()
        {
            var m1 = new Meter(4);
            var m2 = new Meter(2);
            var r = m1 + m2;
            Assert.AreEqual(6, r.Value);
            Assert.AreEqual(r.GetType(), typeof(Meter));
        }

        [TestMethod]
        public void Subtract()
        {
            var m1 = new Meter(4);
            var m2 = new Meter(2);
            var r = m1 - m2;
            Assert.AreEqual(2, r.Value);
            Assert.AreEqual(r.GetType(), typeof(Meter));
        }

        [TestMethod]
        public void MultiplyScalar1()
        {
            var m1 = new Meter(4);
            var r = m1 * 2;
            Assert.AreEqual(8, r.Value);
            Assert.AreEqual(r.GetType(), typeof(Meter));
        }

        [TestMethod]
        public void MultiplyScalar2()
        {
            var m1 = new Meter(4);
            var r =  2 * m1;
            Assert.AreEqual(8, r.Value);
            Assert.AreEqual(r.GetType(), typeof(Meter));
        }

        [TestMethod]
        public void DivideScalar()
        {
            var m1 = new Meter(4);
            var r = m1 / 2;
            Assert.AreEqual(2, r.Value);
            Assert.AreEqual(r.GetType(), typeof(Meter));
        }

        [TestMethod]
        public void DivideByUnit()
        {
            var m1 = new Meter(4);
            var m2 = new Meter(2);
            var r = m1 / m2;
            Assert.AreEqual(2, r);
            Assert.AreEqual(r.GetType(), typeof(BigDouble));
        }

        [TestMethod]
        public void GreaterThan()
        {
            var m1 = new Meter(4);
            var m2 = new Meter(2);
            Assert.IsTrue(m1 > m2);
            Assert.IsFalse(m2 > m1);
        }

        [TestMethod]
        public void GreaterOrEqual()
        {
            var m1 = new Meter(4);
            var m2 = new Meter(2);
            var m3 = new Meter(4);
            Assert.IsTrue(m1 >= m2);
            Assert.IsTrue(m1 >= m3);
            Assert.IsTrue(m3 >= m1);
            Assert.IsFalse(m2 >= m1);
        }

        [TestMethod]
        public void LessThan()
        {
            var m1 = new Meter(4);
            var m2 = new Meter(2);
            Assert.IsTrue(m2 < m1);
            Assert.IsFalse(m1 < m2);
        }

        [TestMethod]
        public void LessThanOrEqual()
        {
            var m1 = new Meter(4);
            var m2 = new Meter(2);
            var m3 = new Meter(4);
            Assert.IsTrue(m2 <= m1);
            Assert.IsTrue(m3 <= m1);
            Assert.IsTrue(m1 <= m3);
            Assert.IsFalse(m1 <= m2);
        }

        [TestMethod]
        public void Equal()
        {
            var m1 = new Meter(4);
            var m2 = new DeciMeter(40);
            var m3 = new Meter(1);
            Assert.IsTrue(m1 == m2);
            Assert.IsFalse(m1 == m3);
        }

        [TestMethod]
        public void UnEqual()
        {
            var m1 = new Meter(4);
            var m2 = new Meter(2);
            var m3 = new CentiMeter(400);
            Assert.IsTrue(m1 != m2);
            Assert.IsFalse(m1 != m3);

        }

        [TestMethod]
        public void Conversion()
        {
            var m = new Meter() { Value = 1 };
            Assert.IsInstanceOfType(m, typeof(Meter));

            var cm = new CentiMeter { Value = 100 };
            Assert.IsInstanceOfType(cm, typeof(CentiMeter));

            Assert.AreEqual(m, cm);

            var convm = m.Convert<Meter>();
            Assert.AreEqual(m, convm);
            Assert.IsInstanceOfType(convm, typeof(Meter));

            var convcm = cm.Convert<Meter>();
            Assert.AreEqual(m, convcm);
            Assert.IsInstanceOfType(convcm, typeof(Meter));
        }
    }
}
