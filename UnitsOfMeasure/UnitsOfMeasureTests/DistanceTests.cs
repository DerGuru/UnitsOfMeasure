using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitsOfMeasure;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class DistanceTests
    {
        public void AreA<T,U>(double valueinT) where T : Distance, new() where U : Distance, new()
        {
            var m = new T() { Value = valueinT };
            Assert.AreEqual<double>(1, Math.Round(m.Convert<U>().Value,4));
        }

        public void In<T,U>(double valueinT) where T : Distance, new() where U : Distance, new()
        {
            var m = new T() { Value = 1 };
            Assert.AreEqual<double>(valueinT, Math.Round(m.Convert<U>().Value, 4));
        }

        public void AreAMeter<T>(double valueinT) where T : Distance, new()
        {
            AreA<T, Meter>(valueinT);
        }

        public void InMeter<T>(double valueinT) where T : Distance, new()
        {
           In<T,Meter>(valueinT);
        }

        [TestMethod]
        public void AstroUnit()
        {
            InMeter<AstronomicUnit>(149597870700);
        }

       
        [TestMethod]
        public void Centimeter()
        {
            AreAMeter<CentiMeter>(100.0);
        }
        [TestMethod]
        public void Decimeter()
        {
            AreAMeter<DeciMeter>(10.0);
        }
       
        [TestMethod]
        public void Foot()
        {
            InMeter<Foot>(0.3048);
        }

        [TestMethod]
        public void Inch()
        {
            InMeter<Inch>(0.0254);
        }

        [TestMethod]
        public void KiloMeterInMeter()
        {
            InMeter<KiloMeter>(1000.0);
        }

        [TestMethod]
        public void LightYear()
        {
            InMeter<LightYear>(9460730472580800);
        }
        [TestMethod]
        public void LunarDistance()
        {
            InMeter<LunarDistance>(3842402000);
        }

        [TestMethod]
        public void Meter0()
        {
            AreAMeter<Meter>(1.0);

        }

        [TestMethod]
        public void Meter1()
        {
            InMeter<Meter>(1.0);
        }

        [TestMethod]
        public void MicroMeter()
        {
            AreAMeter<MicroMeter>(1000000.0);
        }
        [TestMethod]
        public void Mile()
        {
            InMeter<Mile>(1609.3472);
        }
        [TestMethod]
        public void Millimeter()
        {
            AreAMeter<MilliMeter>(1000.0);
        }
        [TestMethod]
        public void Nanometer()
        {
            AreAMeter<NanoMeter>(1000000000.0);
        }
        [TestMethod]
        public void Parsec()
        {
            InMeter<Parsec>(30856775814913673);
        }
        [TestMethod]
        public void Yard()
        {
            InMeter<Yard>(0.9144);
        }

        [TestMethod]
        public void Feet3Eq1Yd()
        {
            AreA<Foot,Yard>(3);
        }

        [TestMethod]
        public void Inch12Foot()
        {
            AreA<Inch,Foot>(12);
        }

        [TestMethod]
        public void YardToMile()
        {
            AreA<Yard,Mile>(1760.0035);
        }

    }
}
