using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitsOfMeasure;
using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;
using UnitsOfMeasure.Velocities;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class VelocityTests
    {
        [TestMethod]
        public void MetersPerScond()
        {
            var dm = new Meter();
            var ts = new Second();
            var vmps = dm / ts;
            Assert.IsInstanceOfType(vmps, typeof(Velocity));
            Assert.IsNotInstanceOfType(vmps, typeof(MetersPerSecond));

        }

        [TestMethod]
        public void ConvertVelocityToSpecialUnit()
        {
            var vmps = new Velocity<Meter, Second>(2, 3);

            Assert.AreEqual(2.0 / 3, vmps.Value);

            var mps = vmps.Convert<MetersPerSecond>();
            Assert.IsInstanceOfType(mps, typeof(MetersPerSecond));
            Assert.IsInstanceOfType(mps, typeof(Velocity));

            Assert.AreEqual(mps.SiUnit, vmps.SiUnit);
            Assert.AreEqual(mps.Value, vmps.Value);
           
        }

        [TestMethod]
        public void MetersPerSecondIntoKilometersPerHour()
        {
            var mps = new MetersPerSecond(2);
            var v = mps.Convert<KiloMetersPerHour>();

            Assert.IsInstanceOfType(v, typeof(Velocity));
            Assert.AreEqual(7.2, Math.Round(v.Value, 1));
        }
    }

}
