using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using UnitsOfMeasure;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasureTests
{

    public static class DistanceExtensions
    {
        public static void AreOne<T>(this Distance val) where T : Distance, new()
        {
            var m = new T() { Value = 1 };
            AreEqualTo(val, m);
        }

        public static void AreEqualTo(this Distance m, Distance other)
        {
            var c = m.Convert(other);
            Assert.AreEqual<BigFloat>(other.Value, c.Value);
            Assert.IsTrue(m.Equals(other));
            Assert.IsTrue(other.Equals(m));
        }
    }

    [TestClass]
    public class DistanceTests
    {
        public void AreA<T, U>(BigFloat valueinT) where T : Distance, new() where U : Distance, new()
        {
            var m = new T() { Value = valueinT };
            Assert.AreEqual(1, m.Convert<U>().Value);
        }

        public void In<T, U>(BigFloat valueinT) where T : Distance, new() where U : Distance, new()
        {
            var m = new T() { Value = 1 };
            Assert.AreEqual(valueinT, m.Convert<U>().Value);
        }

        public void AreAMeter<T>(BigFloat valueinT) where T : Distance, new()
        {
            BigFloat bf = new BigFloat(valueinT);
            AreA<T, Meter>(bf);
        }

        public void InMeter<T>(BigFloat valueinT) where T : Distance, new()
        {

            In<T, Meter>(valueinT);
        }

        [TestMethod]
        public void AstroUnit()
        {
            InMeter<AstronomicUnit>(149597870700);
            new AstronomicUnit(1).AreEqualTo(new Meter(149597870700));
        }


        [TestMethod]
        public void Centimeter()
        {
            new CentiMeter(100).AreOne<Meter>();
            AreAMeter<CentiMeter>(100.0);
        }
        [TestMethod]
        public void Decimeter()
        {
            AreAMeter<DeciMeter>(10.0);
            new DeciMeter(10).AreOne<Meter>();
        }

        [TestMethod]
        public void Foot()
        {
            InMeter<Foot>(new BigFloat(3048,10000));
            new CentiMeter(30.48).AreOne<Foot>();
        }

        [TestMethod]
        public void Inch()
        {
            InMeter<Inch>(new BigFloat(254,10000));
            new CentiMeter(2.54).AreOne<Inch>();
        }

        [TestMethod]
        public void KiloMeterInMeter()
        {
            InMeter<KiloMeter>(1000.0);
            new Meter(1000).AreOne<KiloMeter>();
        }

        [TestMethod]
        public void LightYear()
        {
            InMeter<LightYear>(9460730472580800);
            new Meter(9460730472580800).AreOne<LightYear>();
        }
        [TestMethod]
        public void LunarDistance()
        {
            InMeter<LunarDistance>(3842402000);
            new Meter(3842402000).AreOne<LunarDistance>();
        }

        [TestMethod]
        public void Meter()
        {
            AreAMeter<Meter>(1.0);
            new Meter(1).AreOne<Meter>();

        }

        [TestMethod]
        public void MicroMeter()
        {
            AreAMeter<MicroMeter>(1000000.0);
            new MicroMeter(1000000).AreOne<Meter>();
        }
        [TestMethod]
        public void Mile()
        {
            InMeter<Mile>(1609.3472);
            new Meter(1609.3472).AreOne<Mile>();
        }
        [TestMethod]
        public void Millimeter()
        {
            AreAMeter<MilliMeter>(1000.0);
            new MilliMeter(1000).AreOne<Meter>();
        }
        [TestMethod]
        public void Nanometer()
        {
            AreAMeter<NanoMeter>(1000000000.0);
            new NanoMeter(1000000000).AreOne<Meter>();
        }
        [TestMethod]
        public void Parsec()
        {
            new Meter(new BigFloat(30856775814913673,1)).AreOne<Parsec>();
            InMeter<Parsec>(30856775814913673);
        }
        [TestMethod]
        public void Yard()
        {
            InMeter<Yard>(0.9144);
            new Yard(1).AreEqualTo(new Meter(0.9144));
        }

        [TestMethod]
        public void Feet3Eq1Yd()
        {
            AreA<Foot, Yard>(3);
            new Foot(3).AreOne<Yard>();
        }

        [TestMethod]
        public void Inch12Foot()
        {
            AreA<Inch, Foot>(12);
            new Inch(12).AreOne<Foot>();
        }

        [TestMethod]
        public void YardToMile()
        {
            var bf = new Mile().FactorToBaseUnit / new Yard().FactorToBaseUnit;
            new Yard(bf).AreOne<Mile>();
            AreA<Yard, Mile>(bf);
        }

    }
}
