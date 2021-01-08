using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsOfMeasure;
using UnitsOfMeasure.Areas;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class AreaTests
    {

        public void AreaTest<T, U>(T tval, U uval, double result) where T : Distance, new() where U : Distance, new()
            => AreaTest<T, U, SquareMeter>(tval, uval, result);

        public void AreaTest<S1, S2, T>(S1 tval, S2 uval, double result) where T : Area, new() where S1 : Distance where S2 : Distance
        {
            var m = tval * uval;
            Assert.AreEqual<double>(result, m.Convert<T>().Value);

        }

        [TestMethod]
        public void SqareMeter()
        {
            AreaTest(new Meter(), new Meter(), 1.0);
        }

        [TestMethod]
        public void MeterTimesKiloMeter()
        {
            AreaTest(new Meter(), new KiloMeter(), 1000.0);
        }

        [TestMethod]
        public void KiloMeterTimeMeter()
        {
            AreaTest<KiloMeter, Meter, SquareKiloMeter>(new KiloMeter(), new Meter(), 0.001);
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
