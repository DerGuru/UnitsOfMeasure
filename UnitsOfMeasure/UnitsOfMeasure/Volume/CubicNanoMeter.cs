using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicNanoMeter : Volume<NanoMeter>
    {
        public CubicNanoMeter()
        {
        }

        public CubicNanoMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "nm³";

    }
}
