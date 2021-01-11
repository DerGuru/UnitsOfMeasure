using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Meter : Distance
    {
        public Meter() { }

        public Meter(double value) : base (value) { }

        public Meter(BigFloat value) : base(value) { }

        public override string Unit => "m";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1);
    }
}