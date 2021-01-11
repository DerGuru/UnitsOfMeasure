using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class MilliSecond : Time
    {
        public MilliSecond() { }

        public MilliSecond(double value) : base(value) { }

        public MilliSecond(BigFloat value) : base(value) { }

        public override string Unit => "ms";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.001);
    }

}
