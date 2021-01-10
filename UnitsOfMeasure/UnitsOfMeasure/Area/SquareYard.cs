
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareYard : Area
    {
        public SquareYard() : this(1)
        {
        }

        public SquareYard(double value) : base(value)
        {
        }

        public override string SiUnit => "yd²";

        internal override double FactorToBaseUnit => 0.83612736;
    }

}
