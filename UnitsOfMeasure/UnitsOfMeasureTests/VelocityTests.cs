using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;
using UnitsOfMeasure;
using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Frequencies;
using UnitsOfMeasure.Times;
using UnitsOfMeasure.Velocities;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class VelocityTests
    {
        [TestMethod]
        public void SiUnit()
        {
            Assert.IsInstanceOfType(Velocity.SiUnit, typeof(MetersPerSecond));
        }

        [TestMethod]
        public void VelocityToDistance1()
        {
            var v = new KiloMetersPerHour(1);
            var t = new Hour(1);
            var km = v * t;
            km.AreOne<KiloMeter>("km");
        }


        [TestMethod]
        public void VelocityToDistance2()
        {
            var v = new KiloMetersPerHour(1);
            var t = new Hour(1);
            var km = t * v;
            km.AreOne<KiloMeter>("km");
        }

        [TestMethod]
        public void VelocityToFrequency()
        {
            var v = new MetersPerSecond(1);
            var m = new Meter(1);
            var t = v / m;
            t.AreOne<Herz>("(m/s/m)");
            t.AreOne<Herz>("Hz");
        }


        [TestMethod]
        public void VelocityToTime2()
        {
            var km = new KiloMeter(1);
            var v = new KiloMetersPerHour(1);
            var t = km / v;
            t.AreOne<Hour>("h");
        }


        [TestMethod]
        public void MetersPerSecond()
        {
            var v = new Meter(1) / new Second(1);
            Assert.AreEqual(1, v.Value);
            Assert.AreEqual(1, v.FactorToBaseUnit);
            Assert.AreEqual("(m/s)", v.Unit);
        }

        [TestMethod]
        public void MilesPerHour()
        {
            var v1 = new MilesPerHour(1);
            var v2 = new Mile(1) / new Hour(1);
            v1.AreEqualTo(v2, "mi/h");
            Assert.AreEqual($"({v1.Unit})", v2.Unit);
        }

        [TestMethod]
        public void KiloMetersPerHour()
        {
            var v1 = new KiloMetersPerHour(1);
            var v2 = new KiloMeter(1) / new Hour(1);
            v1.AreEqualTo(v2, "km/h");
            Assert.AreEqual($"({v1.Unit})", v2.Unit);
        }

    }

}
