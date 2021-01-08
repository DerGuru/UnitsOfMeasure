
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMilliMeter : Volume<MilliMeter>
    {
        public CubicMilliMeter()
        {
        }

        public CubicMilliMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "mm³";

    }
}
