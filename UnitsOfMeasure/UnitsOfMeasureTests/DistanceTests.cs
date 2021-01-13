using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using UnitsOfMeasure;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class DistanceTests
    {
        [TestMethod]
        public void SiUnit()
        {
            Assert.IsInstanceOfType(Distance.SiUnit, typeof(Meter));
        }

        [TestMethod]
        public void AstroUnit()
        {
            new Meter(149597870700).AreOne<AstronomicUnit>("au");
        }


        [TestMethod]
        public void Centimeter()
        {
            new CentiMeter(100).AreOne<Meter>("cm");

        }
        [TestMethod]
        public void Decimeter()
        {

            new DeciMeter(10).AreOne<Meter>("dm");
        }

        [TestMethod]
        public void Foot()
        {

            new CentiMeter(30.48).AreOne<Foot>("'");
        }

        [TestMethod]
        public void Inch()
        {
            new CentiMeter(2.54).AreOne<Inch>("\"");
        }

        [TestMethod]
        public void KiloMeterInMeter()
        {

            new Meter(1000).AreOne<KiloMeter>("km");
        }

        [TestMethod]
        public void LightYear()
        {

            new Meter(9460730472580800).AreOne<LightYear>("ly");
        }
        [TestMethod]
        public void LunarDistance()
        {

            new Meter(3842402000).AreOne<LunarDistance>("ld");
        }

        [TestMethod]
        public void Meter()
        {

            new Meter(1).AreOne<Meter>("m");

        }

        [TestMethod]
        public void MicroMeter()
        {

            new MicroMeter(1000000).AreOne<Meter>("μm");
        }
        [TestMethod]
        public void Mile()
        {
            new Meter(1609.344).AreOne<Mile>("mi");
        }
        [TestMethod]
        public void Millimeter()
        {
            new MilliMeter(1000).AreOne<Meter>("mm");
        }
        [TestMethod]
        public void Nanometer()
        {

            new NanoMeter(1000000000).AreOne<Meter>("nm");
        }
        [TestMethod]
        public void Parsec()
        {
            new Meter(new BigDouble(30856775814913673)).AreOne<Parsec>("pc");

        }
        [TestMethod]
        public void Yard()
        {
            new Meter(0.9144).AreOne<Yard>("yd");
        }

        [TestMethod]
        public void Inch12Foot()
        {

            new Inch(12).AreOne<Foot>("\"");
        }


        [TestMethod]
        public void Feet3Eq1Yd()
        {

            new Foot(3).AreOne<Yard>("'");
        }

        [TestMethod]
        public void YardToMile()
        {
            new Yard(1760).AreOne<Mile>("mi");
        }

    }
}
