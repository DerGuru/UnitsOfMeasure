using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class SquareMicroMeters : Area<SquareMicroMeters>
    {
        public SquareMicroMeters()
        {
        }

        public SquareMicroMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "μm²";

        internal override double FactorToBaseUnit => 0.000000000001;
    }

}
