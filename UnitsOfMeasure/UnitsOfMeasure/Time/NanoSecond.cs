using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class NanoSecond : Time
    {
        public NanoSecond() { }

        public NanoSecond(double value) : base(value) { }

        public NanoSecond(BigFloat value) : base(value) { }

        public override string Unit => "ns";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.000000001);
    }

}
