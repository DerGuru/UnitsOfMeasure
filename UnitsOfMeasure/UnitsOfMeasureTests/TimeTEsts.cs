using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using UnitsOfMeasure;
using UnitsOfMeasure.Areas;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class TimeTests
    {

        [TestMethod]
        public void Ar()
        {
            new SquareMeter(100).AreOne<Ar>();
        }

        [TestMethod]
        public void Earth()
        {
            new SquareMeter(510000000000000).AreOne<Earth>();
        }

        [TestMethod]
        public void Hectar()
        {
            new SquareMeter(10000).AreOne<Hectar>();
        }

        [TestMethod]
        public void Moon()
        {
            new SquareKiloMeter(new BigDouble(37932330)).AreOne<Moon>();
        }

        [TestMethod]
        public void Saarland()
        {
            new SquareMeter(2570000000).AreOne<Saarland>();
        }

        [TestMethod]
        public void Soccerfield()
        {
            new SquareMeter(7140).AreOne<SoccerField>();
        }

        [TestMethod]
        public void FootballField()
        {
            var ff = new FootballField(1);
            var x = new Yard(100);
            var y = new Foot(160);
            var a =  x * y;
            Assert.AreEqual(a, ff);
            var sqm = ff.Convert<SquareMeter>();
            Assert.IsTrue( sqm.Value == ff.FactorToBaseUnit);
        }
        [TestMethod]
        public void CentiMeter()
        {
            new SquareCentiMeter(10000).AreOne<SquareMeter>();
        }
        [TestMethod]
        public void DeciMeter()
        {
            new SquareDeciMeter(100).AreOne<SquareMeter>();
        }
        [TestMethod]
        public void Foot()
        {
            var bf = new SquareMeter(1).FactorToBaseUnit / new SquareFoot(1).FactorToBaseUnit;
            new SquareFoot(bf).AreOne<SquareMeter>();
        }
        [TestMethod]
        public void Inch()
        {
            var bf = new SquareMeter(1).FactorToBaseUnit / new SquareInch(1).FactorToBaseUnit;
            new SquareInch(bf).AreOne<SquareMeter>();
        }
        [TestMethod]
        public void KiloMeter()
        {
            new SquareMeter(1000000).AreOne<SquareKiloMeter>();
        }
        [TestMethod]
        public void Meter()
        {
            new SquareMeter(1).AreOne<SquareMeter>();
        }
        [TestMethod]
        public void Micrometer()
        {
            new SquareMicroMeter(1000000000000).AreOne<SquareMeter>();
        }
        [TestMethod]
        public void Mile()
        {
            new SquareMeter(2589988.110336).AreOne<SquareMile>();
        }
        [TestMethod]
        public void MilliMeter()
        {
            new SquareMilliMeter(1000000).AreOne<SquareMeter>();
        }
        [TestMethod]
        public void NanoMeter()
        {
            new SquareNanoMeter(1000000).AreOne<SquareMicroMeter>();
        }
        [TestMethod]
        public void Yard()
        {
            var bd = new BigDouble(100000000) / new BigDouble(83612736);
            new SquareYard(bd).AreOne<SquareMeter>();
        }

        [TestMethod]
        public void FooBar()
        {
            var a = new Hectar(1);
            var d = new Meter(100);

            var res = a / d;
            var m = res.Convert<Meter>();
            Assert.AreEqual(100.0, m.Value);
        }
    }

}
