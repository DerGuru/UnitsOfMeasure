
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareDeciMeter : Area
    {
        public SquareDeciMeter() : this(1)
        {
        }

        public SquareDeciMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "dm²";

        internal override double FactorToBaseUnit => 0.01;
    }

}
