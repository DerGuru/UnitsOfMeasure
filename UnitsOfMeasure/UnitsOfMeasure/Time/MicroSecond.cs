using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class MicroSecond : Time
    {
        public MicroSecond() { }

        public MicroSecond(double value) : base(value) { }

        public MicroSecond(BigFloat value) : base(value) { }

        public override string Unit => "μs";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.000001);
    }

}
