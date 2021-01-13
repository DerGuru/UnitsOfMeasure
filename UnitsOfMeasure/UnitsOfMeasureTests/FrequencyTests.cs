using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsOfMeasure;
using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Frequencies;
using UnitsOfMeasure.Times;
using UnitsOfMeasure.Velocities;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class FrequencyTests
    {
        [TestMethod]
        public void SiUnit()
        {
            Assert.IsInstanceOfType(Frequency.SiUnit, typeof(Herz));
        }

        [TestMethod]
        public void NanoToMicro()
        {
            new NanoHerz(1000).AreOne<MicroHerz>("nHz");
        }
        [TestMethod]
        public void MicroToMilli()
        {
            new MicroHerz(1000).AreOne<MilliHerz>("μHz");
        }
        [TestMethod]
        public void MilliToHerz()
        {
            new MilliHerz(1000).AreOne<Herz>("mHz");
        }
       
        [TestMethod]
        public void HerzIsHerz()
        {
            new Herz(1).AreOne<Herz>("Hz");
        }

        [TestMethod]
        public void HerzToKiloHerz()
        {
            new Herz(1000).AreOne<KiloHerz>("kHz");
        }

        [TestMethod]
        public void KiloToMega()
        {
            new KiloHerz(1000).AreOne<MegaHerz>("MHz");
        }

        [TestMethod]
        public void MegaToGiga()
        {
            new MegaHerz(1000).AreOne<GigaHerz>("GHz");
        }

        [TestMethod]
        public void GigaToTera()
        {
            new GigaHerz(1000).AreOne<TeraHerz>("THz");
        }

        [TestMethod]
        public void ToNumber()
        {
            var n1 = new GigaHerz(1) * new Second(1);
            var n2 = new Second(1) * new GigaHerz(1);
            var n3 = 1e9;

            Assert.AreEqual(n1, n2);
            Assert.AreEqual(n2, n3);
        }

        [TestMethod]
        public void ToDistance()
        {
            var f = new Herz(1);
            var v = new MetersPerSecond(1);
            var d = v / f;
            d.AreOne<Meter>("(m/s/Hz)");
        }

        [TestMethod]
        public void ToVelocity()
        {
            var f = new Herz(1);
            var d = new Meter(1);
            var v1 = f * d;
            var v2 = d * f;
            v1.AreOne<MetersPerSecond>("Hzm");
            v2.AreOne<MetersPerSecond>("Hzm");
        }
    }

}
