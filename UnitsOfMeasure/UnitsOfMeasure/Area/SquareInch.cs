
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareInch : Area<Inch>
    {
        public SquareInch()
        {
        }

        public SquareInch(double value) : base(value)
        {
        }

        public override string SiUnit => "in²";
    }

}
