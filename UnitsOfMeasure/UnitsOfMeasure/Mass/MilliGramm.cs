using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class MilliGramm : Mass
    {
        public MilliGramm() { }

        public MilliGramm(double value) : base(value) { }

        public MilliGramm(BigFloat value) : base(value) { }

        public override string Unit => "mg";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.001);
    }
}
