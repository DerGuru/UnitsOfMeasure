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
        public void Gramm()
        {
            new Gramm(1).AreOne<Gramm>();
        }

        [TestMethod]
        public void KiloGramm()
        {
            new Gramm(1000).AreOne<KiloGramm>();
        }

        [TestMethod]
        public void MetricTon()
        {
            new KiloGramm(1000).AreOne<MetricTon>();
        }

        [TestMethod]
        public void MilliGramm()
        {
            new MilliGramm(1000).AreOne<Gramm>();
        }


        [TestMethod]
        public void Microgramm()
        {
            new MicroGramm(1000).AreOne<MilliGramm>();
        }

        [TestMethod]
        public void NanoGramm()
        {
            new NanoGramm(1000).AreOne<MicroGramm>();
        }

        [TestMethod]
        public void Grain()
        {
            new Grain(1).AreOne<Grain>();
        }

        [TestMethod]
        public void TroyPound()
        {
            new Grain(5760).AreOne<TroyPound>();
        }

        [TestMethod]
        public void Pound()
        {
            new Grain(7000).AreOne<Pound>();
        }

        [TestMethod]
        public void Ounce()
        {
            new Ounce(16).AreOne<Pound>();
        }

        [TestMethod]
        public void TroyOunce()
        {
            new TroyOunce(12).AreOne<TroyPound>();
        }

        [TestMethod]
        public void Stone()
        {
            new Pound(14).AreOne<Stone>();
        }

        [TestMethod]
        public void Quarter()
        {
            new Stone(2).AreOne<Quarter>();
        }

        [TestMethod]
        public void HundredWeight()
        {
            new Stone(8).AreOne<HundredWeight>();
        }

    }
}
