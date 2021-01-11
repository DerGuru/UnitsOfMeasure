using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;
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
        public void ConvertVelocityToSpecialUnit()
        {
            var vmps = new Velocity<Meter, Second>(new Meter(2), new Second(3));

            Assert.AreEqual(new BigFloat(2 ,3), vmps.Value);

            var mps = vmps.Convert<MetersPerSecond>();
            Assert.IsInstanceOfType(mps, typeof(MetersPerSecond));
            Assert.IsInstanceOfType(mps, typeof(Velocity));

            Assert.AreEqual($"({mps.Unit})", vmps.Unit);
            Assert.AreEqual(mps.Value, vmps.Value);
           
        }

        [TestMethod]
        public void MetersPerSecondIntoKilometersPerHour()
        {
            var mps = new MetersPerSecond(2);
            var v = mps.Convert<KiloMetersPerHour>();

            Assert.IsInstanceOfType(v, typeof(Velocity));
            Assert.AreEqual(7.2, v.Value);
        }
    }

}
