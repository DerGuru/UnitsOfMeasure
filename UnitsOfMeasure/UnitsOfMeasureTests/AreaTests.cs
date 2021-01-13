using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using UnitsOfMeasure;
using UnitsOfMeasure.Areas;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void SiUnit()
        {
            Assert.IsInstanceOfType(Area.SiUnit, typeof(SquareMeter));
        }

        [TestMethod]
        public void DistanceToArea()
        {
            var d = new Meter(1);
            (d * d).AreOne<SquareMeter>("m²");
        }

        [TestMethod]
        public void AreaToDistance()
        {
            var a = new SquareMeter(1);
            var d = new Meter(1);
            (a / d).AreOne<Meter>("(m²/m)");
        }
        [TestMethod]
        public void CreateSquare()
        {
            Area.CreateSquare(new Meter(1)).AreOne<SquareMeter>("m²");
        }
        [TestMethod]
        public void CreateRectangle()
        {
            Area.CreateRectangle(new Meter(0.5),new Meter(2)).AreOne<SquareMeter>("m²");
        }
        [TestMethod]
        public void CreateCircle()
        {
            Area.CreateCircle(new Meter(1)).AreEqualTo(new SquareMeter(System.Math.PI), "m²");
        }

        [TestMethod]
        public void Earth()
        {
            new SquareMeter(510000000000000).AreOne<Earth>("Earth(s)");
        }

        [TestMethod]
        public void Sun()
        {
            new SquareKiloMeter(new BigDouble(6.0874, 12)).AreOne<Sun>("Sun(s)");
        }

        [TestMethod]
        public void Hectar()
        {
            new SquareMeter(10000).AreOne<Hectar>("ha");
        }

        [TestMethod]
        public void Moon()
        {
            new SquareKiloMeter(new BigDouble(37932330)).AreOne<Moon>("Moon(s)");
        }

        [TestMethod]
        public void Saarland()
        {
            new SquareMeter(2570000000).AreOne<Saarland>("Saarland");
        }

        [TestMethod]
        public void Soccerfield()
        {
            new SquareMeter(7140).AreOne<SoccerField>("Soccerfield(s)");
        }

        [TestMethod]
        public void FootballField()
        {
            var ff = new FootballField(1);
            var x = new Yard(100);
            var y = new Foot(160);
            var a =  x * y;
            a.AreOne<FootballField>("Footballfield(s)");
            Assert.AreEqual(a, ff);
        }
        [TestMethod]
        public void CentiMeter()
        {
            new SquareCentiMeter(10000).AreOne<SquareMeter>("cm²");
        }
        [TestMethod]
        public void DeciMeter()
        {
            new SquareDeciMeter(100).AreOne<SquareMeter>("dm²");
        }
        [TestMethod]
        public void Foot()
        {
            var bf = new SquareMeter(1).FactorToBaseUnit / new SquareFoot(1).FactorToBaseUnit;
            new SquareFoot(bf).AreOne<SquareMeter>("ft²");
        }
        [TestMethod]
        public void Inch()
        {
            var bf = new SquareMeter(1).FactorToBaseUnit / new SquareInch(1).FactorToBaseUnit;
            new SquareInch(bf).AreOne<SquareMeter>("in²");
        }
        [TestMethod]
        public void KiloMeter()
        {
            new SquareMeter(1000000).AreOne<SquareKiloMeter>("km²");
        }
        [TestMethod]
        public void Meter()
        {
            new SquareMeter(1).AreOne<SquareMeter>("m²");
        }
        [TestMethod]
        public void Micrometer()
        {
            new SquareMicroMeter(1000000000000).AreOne<SquareMeter>("μm²");
        }
        [TestMethod]
        public void Mile()
        {
            new SquareMeter(2589988.110336).AreOne<SquareMile>("mi²");
        }
        [TestMethod]
        public void MilliMeter()
        {
            new SquareMilliMeter(1000000).AreOne<SquareMeter>("mm²");
        }
        [TestMethod]
        public void NanoMeter()
        {
            new SquareNanoMeter(1000000).AreOne<SquareMicroMeter>("nm²");
        }
        [TestMethod]
        public void Yard()
        {
            var bd = new BigDouble(100000000) / new BigDouble(83612736);
            new SquareYard(bd).AreOne<SquareMeter>("yd²");
        }
    }

}
