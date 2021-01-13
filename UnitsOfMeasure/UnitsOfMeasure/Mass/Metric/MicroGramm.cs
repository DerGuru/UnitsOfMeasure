using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class MicroGramm : Mass
    {
        public MicroGramm() { }
        public MicroGramm(BigDouble value) : base(value) { }
        public override string Unit => "μg";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,-6);
    }
}
