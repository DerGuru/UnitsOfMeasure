
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareKiloMeter : Area
    {
        public SquareKiloMeter() { }

        public SquareKiloMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "km²";

        internal override double FactorToBaseUnit => 1000000;
    }

}
