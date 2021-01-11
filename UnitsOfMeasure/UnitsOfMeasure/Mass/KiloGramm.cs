using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class KiloGramm : Mass
    {
        public KiloGramm() { }

        public KiloGramm(double value) : base(value) { }

        public KiloGramm(BigFloat value) : base(value) { }

        public override string Unit => "kg";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1000);
    }
}
