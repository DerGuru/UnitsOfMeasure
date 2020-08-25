using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsOfMeasure;
using UnitsOfMeasure.Areas;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sqm = new SquareMeters(1);
            var m = new Meters(1);
            var km = new KiloMeters(1);
            Assert.IsTrue(m < km);

            Area.Create<SquareCentiMeters>(100);
        }
    }
}
