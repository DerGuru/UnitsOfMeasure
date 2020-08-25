using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class SquareDeciMeters : Area<SquareDeciMeters>
    {
        public SquareDeciMeters()
        {
        }

        public SquareDeciMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "dm²";

        internal override double FactorToBaseUnit => 0.01;
    }

}
