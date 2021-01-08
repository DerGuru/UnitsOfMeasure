using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicDeciMeter : Volume<DeciMeter>
    {
        public CubicDeciMeter()
        {
        }

        public CubicDeciMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "dm³";
    }
}
