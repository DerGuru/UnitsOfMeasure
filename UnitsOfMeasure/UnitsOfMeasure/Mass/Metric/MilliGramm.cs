using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class MilliGramm : Mass
    {
        public MilliGramm() { }
        public MilliGramm(BigDouble value) : base(value) { }
        public override string Unit => "mg";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -3);
    }
}
