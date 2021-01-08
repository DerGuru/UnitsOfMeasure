
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareYard : Area<Yard>
    {
        public SquareYard()
        {
        }

        public SquareYard(double value) : base(value)
        {
        }

        public override string SiUnit => "yd²";

    }

}
