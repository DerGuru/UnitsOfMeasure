using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class MicroGramm : Mass
    {
        public MicroGramm() { }

        public MicroGramm(double value) : base(value) { }

        public MicroGramm(BigFloat value) : base(value) { }

        public override string Unit => "μg";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.000001);
    }
}
