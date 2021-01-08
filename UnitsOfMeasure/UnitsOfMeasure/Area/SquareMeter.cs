
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareMeter : Area<Meter>
    {
        public SquareMeter()
        {
        }

        public SquareMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "m²";

    }

}
