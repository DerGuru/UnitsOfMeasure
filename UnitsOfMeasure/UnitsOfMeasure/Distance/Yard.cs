using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Yard : Distance
    {
        public Yard() { }

        public Yard(double value) : base(value) { }

        public Yard(BigFloat value) : base(value) { }

        public override string Unit => "yd";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(9144,10000);
    }
}
