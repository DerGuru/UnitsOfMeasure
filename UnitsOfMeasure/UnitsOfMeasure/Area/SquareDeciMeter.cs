using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareDeciMeter : Area<DeciMeter>
    {
        public SquareDeciMeter()
        {
        }

        public SquareDeciMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "dm²";

        internal override double FactorToBaseUnit => 0.01;
    }

}
