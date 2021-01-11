using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class NanoGramm : Mass
    {
        public NanoGramm() { }

        public NanoGramm(double value) : base(value) { }

        public NanoGramm(BigFloat value) : base(value) { }

        public override string Unit => "ng";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.000000001);
    }
}
