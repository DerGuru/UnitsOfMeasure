using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using UnitsOfMeasure;
using UnitsOfMeasure.Volumes;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class VolumeTests
    {
        [TestMethod]
        public void SiUnit()
        {
            Assert.IsInstanceOfType(Volume.SiUnit, typeof(CubicMeter));
        }

        [TestMethod]
        public void AreaToVolume()
        {
            var a = Area.CreateSquare(new UnitsOfMeasure.Distances.Meter(1));
            var d = new UnitsOfMeasure.Distances.Meter(1);
            var v1 = a * d;
            var v2 = d * a;
            v1.AreEqualTo(v2, "mmm");
            new CubicMeter(1).AreEqualTo(v1, "m³");
        }

        [TestMethod]
        public void ToArea()
        {
            var a = Volume.CreateCuboid(new UnitsOfMeasure.Distances.Meter(1), new UnitsOfMeasure.Distances.Meter(1), new UnitsOfMeasure.Distances.Meter(1)) / new UnitsOfMeasure.Distances.Meter(1);
            a.AreOne<UnitsOfMeasure.Areas.SquareMeter>("m²");
        }

        [TestMethod]
        public void ToDistance()
        {
            var a = new CubicMeter(1) / new UnitsOfMeasure.Areas.SquareMeter(1);
            a.AreOne<UnitsOfMeasure.Distances.Meter>("m");
        }

        [TestMethod]
        public void NanoMeterToMicroMeter()
        {
            new CubicNanoMeter(1000000000).AreOne<CubicMicroMeter>("nm³");
        }
        [TestMethod]
        public void MicroMeterToMillimeter()
        {
            new CubicMicroMeter(1000000000).AreOne<CubicMilliMeter>("μm³");
        }
        [TestMethod]
        public void MillimeterToCentiMeter()
        {
            new CubicMilliMeter(1000).AreOne<CubicCentiMeter>("mm³");
        }
        [TestMethod]
        public void CentiMeterToDeciMeter()
        {
            new CubicCentiMeter(1000).AreOne<CubicDeciMeter>("cm³");
        }
        [TestMethod]
        public void DeciMeterToMeter()
        {
            new CubicDeciMeter(1000).AreOne<CubicMeter>("dm³");
        }
        [TestMethod]
        public void MeterToMeter()
        {
            new CubicMeter(1).AreOne<CubicMeter>("m³");
        }
        [TestMethod]
        public void MeterToKiloMeter()
        {
            new CubicMeter(1000000000).AreOne<CubicKiloMeter>("km³");
        }
        [TestMethod]
        public void InchToMeter()
        {
            new CubicInch(1/CubicInch.MetricFactor).AreOne<CubicMeter>("in³");
        }

        [TestMethod]
        public void InchToFoot()
        {
            new CubicInch(12*12*12).AreOne<CubicFoot>("ft³");
        }
        [TestMethod]
        public void FootToYard()
        {
            new CubicFoot(3*3*3).AreOne<CubicYard>("yd³");
        }
        [TestMethod]
        public void YardToMile()
        {
            new CubicYard(1760.0 * 1760.0 * 1760.0).AreOne<CubicMile>("mi³");
        }
        [TestMethod]
        public void DeciMeterToLiter()
        {
            new CubicDeciMeter(1).AreOne<Liter>("l");
        }
        [TestMethod]
        public void LiterToHectoLiter()
        {
            new Liter(100).AreOne<HectoLiter>("hl");
        }
        [TestMethod]
        public void OlympicSwimmingPool()
        {
            new CubicMeter(2500).AreOne<OlympicSwimmingPool>("Olympic Swimming Pool(s)");
        }
        [TestMethod]
        public void Moon()
        {
            new CubicMeter(new BigDouble(21990642870864709217827712858943.0, 12)).AreOne<Moon>("Moon(s)");
        }
        [TestMethod]
        public void Earth()
        {
            new CubicMeter(new BigDouble(10832069168457537005471167989961.0, 10)).AreOne<Earth>("Earth(s)");
        }
        [TestMethod]
        public void Sun()
        {
            new CubicMeter(new BigDouble(140927256905986, 23)).AreOne<Sun>("Sun(s)");
        }
        [TestMethod]
        public void SunSystem()
        {
            new CubicMeter(SolarSystem.VolumeInMeter).AreOne<SolarSystem>("Solar System(s)");
        }
    }

}
