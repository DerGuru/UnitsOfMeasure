using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using UnitsOfMeasure;
using UnitsOfMeasure.Areas;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasureTests
{

    public static class AreaExtensions
    {
        public static void AreOne<T>(this Area val) where T : Area, new()
        {
            var m = new T() { Value = 1 };
            AreEqualTo(val, m);
        }

        public static void AreEqualTo(this Area m, Area other)
        {
            var c = m.Convert(other);
            Assert.AreEqual<BigFloat>(other.Value, c.Value);
            Assert.IsTrue(m.Equals(other));
            Assert.IsTrue(other.Equals(m));
        }
    }
    [TestClass]
    public class AreaTests
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
            new SquareMeter(37932330000000).AreOne<Moon>();
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
            var bf = new BigFloat(25899752356, 10000);
            new SquareMeter(bf).AreOne<SquareMile>();
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
            new SquareYard(new BigFloat(100000000, 83612736)).AreOne<SquareMeter>();
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
