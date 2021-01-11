using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class TroyOunce : Mass
    {
        public TroyOunce() { }

        public TroyOunce(double value) : base(value) { }

        public TroyOunce(BigFloat value) : base(value) { }

        public override string Unit => "oz.tr.";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(31.1034768);
    }
}
