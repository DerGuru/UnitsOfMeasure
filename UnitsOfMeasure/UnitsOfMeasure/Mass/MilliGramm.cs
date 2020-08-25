using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class MilliGramm : Mass<MilliGramm>
    {
        public MilliGramm()
        {
        }

        public MilliGramm(double value) : base(value)
        {
        }

        public override string SiUnit => "mg";

        internal override double FactorToBaseUnit => 0.001;
    }
}
