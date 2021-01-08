using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsOfMeasure;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class DistanceTests
    {
        public void DistanceTest<T>(double valueInMeters) where T : Distance, new()
        {
            DistanceTest<T, Meter>(valueInMeters);
        }

        public void DistanceTest<T,U>(double valueInU) where T : Distance, new() where U: Distance, new()
        {
            var m = new T();
            Assert.AreEqual<double>(valueInU, m.Convert<U>().Value);
            
        }

        [TestMethod]
        public void Meter()
        {
            DistanceTest<Meter>(1.0);
        }

        [TestMethod]
        public void KiloMeterInMeter()
        {
            DistanceTest<KiloMeter>(1000.0);
        }

        [TestMethod]
        public void KiloMeterInYard()
        {
            DistanceTest<KiloMeter,Yard>(1093.6132983377079);
        }

        [TestMethod]
        public void LunarInKiloMeter()
        {
            DistanceTest<LunarDistance, KiloMeter>(3842402.0);
        }
    }
}
