
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMeter : Volume<Meter>
    {
        public CubicMeter()
        {
        }

        public CubicMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "m³";

    }
}
