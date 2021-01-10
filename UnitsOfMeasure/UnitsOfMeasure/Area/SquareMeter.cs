
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareMeter : Area
    {
        public SquareMeter()
        {
        }

        public SquareMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "m²";
        internal override double FactorToBaseUnit => 1;

    }

}
