using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class LightYear : Distance
    {
        public LightYear() { }

        public LightYear(double value) : base(value) { }

        public LightYear(BigFloat value) : base(value) { }

        public override string Unit => "ly";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(9460730472580800);
    }
}
