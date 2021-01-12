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
        public void AstroUnit()
        {
            new AstronomicUnit(1).AreEqualTo(new Meter(149597870700));
        }


        [TestMethod]
        public void Centimeter()
        {
            new CentiMeter(100).AreOne<Meter>();

        }
        [TestMethod]
        public void Decimeter()
        {

            new DeciMeter(10).AreOne<Meter>();
        }

        [TestMethod]
        public void Foot()
        {

            new CentiMeter(30.48).AreOne<Foot>();
        }

        [TestMethod]
        public void Inch()
        {
            new CentiMeter(2.54).AreOne<Inch>();
        }

        [TestMethod]
        public void KiloMeterInMeter()
        {

            new Meter(1000).AreOne<KiloMeter>();
        }

        [TestMethod]
        public void LightYear()
        {

            new Meter(9460730472580800).AreOne<LightYear>();
        }
        [TestMethod]
        public void LunarDistance()
        {

            new Meter(3842402000).AreOne<LunarDistance>();
        }

        [TestMethod]
        public void Meter()
        {

            new Meter(1).AreOne<Meter>();

        }

        [TestMethod]
        public void MicroMeter()
        {

            new MicroMeter(1000000).AreOne<Meter>();
        }
        [TestMethod]
        public void Mile()
        {
            new Meter(1609.344).AreOne<Mile>();
        }
        [TestMethod]
        public void Millimeter()
        {
            new MilliMeter(1000).AreOne<Meter>();
        }
        [TestMethod]
        public void Nanometer()
        {

            new NanoMeter(1000000000).AreOne<Meter>();
        }
        [TestMethod]
        public void Parsec()
        {
            new Meter(new BigDouble(30856775814913673)).AreOne<Parsec>();

        }
        [TestMethod]
        public void Yard()
        {

            new Yard(1).AreEqualTo(new Meter(0.9144));
        }

        [TestMethod]
        public void Inch12Foot()
        {

            new Inch(12).AreOne<Foot>();
        }


        [TestMethod]
        public void Feet3Eq1Yd()
        {

            new Foot(3).AreOne<Yard>();
        }

        [TestMethod]
        public void YardToMile()
        {
            new Yard(1760).AreOne<Mile>();
        }

    }
}
