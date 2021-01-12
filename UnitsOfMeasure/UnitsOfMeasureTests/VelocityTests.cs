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
            var vmps = new Meter(2) / new Second(3);
            var bd = new BigDouble(2) / new BigDouble(3);
            Assert.AreEqual(bd, vmps.Value);

            var mps = vmps.Convert<MetersPerSecond>();
            Assert.IsInstanceOfType(mps, typeof(MetersPerSecond));
            Assert.IsInstanceOfType(mps, typeof(Velocity));

            Assert.AreEqual($"({mps.Unit})", vmps.Unit);
            Assert.AreEqual(mps.Value, vmps.Value);
           
        }

        [TestMethod]
        public void MetersPerSecondIntoKilometersPerHour()
        {
            new MetersPerSecond(1).AreEqualTo(new KiloMetersPerHour(3.6));
        }

        [TestMethod]
        public void MilePerHourIntoKilometersPerHour()
        {
            var mpk = new Mile(1) / new KiloMeter(1);
            new MilesPerHour(1).AreEqualTo(new KiloMetersPerHour(mpk));
        }

        [TestMethod]
        public void MachInKmh()
        {
            var mpk = new Mile(1) / new KiloMeter(1);
            new MilesPerHour(1).AreEqualTo(new KiloMetersPerHour(mpk));
        }

    }

}
