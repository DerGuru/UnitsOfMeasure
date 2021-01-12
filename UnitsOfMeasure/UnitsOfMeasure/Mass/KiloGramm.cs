using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class KiloGramm : Mass
    {
        public KiloGramm() { }

        public KiloGramm(double value) : base(value) { }

        public KiloGramm(BigDouble value) : base(value) { }

        public override string Unit => "kg";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, 3);
    }
}
