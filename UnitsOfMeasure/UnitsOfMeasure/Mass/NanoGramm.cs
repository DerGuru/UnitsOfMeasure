using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class NanoGramm : Mass<NanoGramm>
    {
        public NanoGramm()
        {
        }

        public NanoGramm(double value) : base(value)
        {
        }

        public override string SiUnit => "ng";

        internal override double FactorToBaseUnit => 0.000000001;
    }
}
