using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class TroyOunce : Mass
    {
        private static readonly BigDouble Factor = new TroyPound().FactorToBaseUnit / 12;
        public TroyOunce() { }

        public TroyOunce(double value) : base(value) { }

        public TroyOunce(BigDouble value) : base(value) { }

        public override string Unit => "oz.tr.";

        public override BigDouble FactorToBaseUnit { get; set; } =  Factor;
    }
}
