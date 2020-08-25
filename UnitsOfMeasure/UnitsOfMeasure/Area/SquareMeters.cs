using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure.Areas
{
    public class SquareMeters : Area<SquareMeters>
    {
        public SquareMeters()
        {
        }

        public SquareMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "m²";

        internal override double FactorToBaseUnit => 1;
    }

}
