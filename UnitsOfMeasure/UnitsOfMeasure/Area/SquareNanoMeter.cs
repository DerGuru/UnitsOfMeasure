
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareNanoMeter : Area
    {
        public SquareNanoMeter()
        {
        }

        public SquareNanoMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "nm²";

        internal override double FactorToBaseUnit => 0.000000000000000001;
    }

}
