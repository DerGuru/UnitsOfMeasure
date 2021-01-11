using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Second : Time
    {
        public Second() { }

        public Second(double value) : base(value) { }

        public Second(BigFloat value) : base(value) { }

        public override string Unit => "s";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1.0);
    }

}
