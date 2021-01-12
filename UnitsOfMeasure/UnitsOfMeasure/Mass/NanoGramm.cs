using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class NanoGramm : Mass
    {
        public NanoGramm() { }

        public NanoGramm(double value) : base(value) { }

        public NanoGramm(BigDouble value) : base(value) { }

        public override string Unit => "ng";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,-9);
    }
}
