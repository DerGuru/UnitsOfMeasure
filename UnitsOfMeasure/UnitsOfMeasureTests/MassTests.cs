using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using UnitsOfMeasure;
using UnitsOfMeasure.Masses;


namespace UnitsOfMeasureTests
{
    [TestClass]
    public class MassTests
    {
        [TestMethod]
        public void SiUnit()
        {
            Assert.IsInstanceOfType(Mass.SiUnit, typeof(Gramm));
        }
        [TestMethod]
        public void Gramm()
        {
            new Gramm(1).AreOne<Gramm>("g");
        }

        [TestMethod]
        public void KiloGramm()
        {
            new Gramm(1000).AreOne<KiloGramm>("kg");
        }

        [TestMethod]
        public void MetricTon()
        {
            new KiloGramm(1000).AreOne<MetricTon>("t");
        }

        [TestMethod]
        public void MilliGramm()
        {
            new MilliGramm(1000).AreOne<Gramm>("mg");
        }


        [TestMethod]
        public void Microgramm()
        {
            new MicroGramm(1000).AreOne<MilliGramm>("μg");
        }

        [TestMethod]
        public void NanoGramm()
        {
            new NanoGramm(1000).AreOne<MicroGramm>("ng");
        }

        [TestMethod]
        public void Grain_()
        {
            new Grain(1).AreOne<Grain>("gr");
        }

        [TestMethod]
        public void TroyPound()
        {
            new Grain(5760).AreOne<TroyPound>("lb.tr.");
        }

        [TestMethod]
        public void Pound()
        {
            new Grain(7000).AreOne<Pound>("lb");
        }

        [TestMethod]
        public void Ounce()
        {
            new Ounce(16).AreOne<Pound>("oz");
        }

        [TestMethod]
        public void TroyOunce()
        {
            new TroyOunce(12).AreOne<TroyPound>("oz.tr.");
        }

        [TestMethod]
        public void Stone()
        {
            new Pound(14).AreOne<Stone>("st");
        }

        [TestMethod]
        public void Quarter()
        {
            new Stone(2).AreOne<Quarter>("tod");
        }

        [TestMethod]
        public void HundredWeight()
        {
            new Stone(8).AreOne<HundredWeight>("cwt");
        }

        [TestMethod]
        public void GrainToGramm()
        {
            new Grain(1/Grain.GrammPerGrain).AreOne<Gramm>("g");
        }

        [TestMethod]
        public void MoonToTon()
        {
            new MetricTon(new BigDouble(7348, 16)).AreOne<Moon>("t");
        }
        [TestMethod]
        public void EarthToTon()
        {
            new MetricTon(new BigDouble(59736, 17)).AreOne<Earth>("t");
        }
        [TestMethod]
        public void SunToTon()
        {
            new MetricTon(new BigDouble(19891, 32)).AreOne<Sun>("t");
        }
    }
}
