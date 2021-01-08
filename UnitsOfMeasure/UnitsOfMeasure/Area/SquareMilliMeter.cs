
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareMilliMeter : Area<MilliMeter>
    {
        public SquareMilliMeter()
        {
        }

        public SquareMilliMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "mm²";

       
    }

}
