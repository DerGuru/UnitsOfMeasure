
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareMile : Area
    {
        public SquareMile()
        {
        }

        public SquareMile(double value) : base(value)
        {
        }

        public override string SiUnit => "mi²";

        internal override double FactorToBaseUnit => 2589975.2356;
    }

}
