using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareNanoMeter : Area<NanoMeter>
    {
        public SquareNanoMeter()
        {
        }

        public SquareNanoMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "nm²";
    }

}
