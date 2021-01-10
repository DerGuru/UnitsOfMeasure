
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareMilliMeter : Area
    {
        public SquareMilliMeter()
        {
        }

        public SquareMilliMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "mm²";

        internal override double FactorToBaseUnit => 0.000001;
    }

}
