
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMile : Volume<Mile>
    {
        public CubicMile()
        {
        }

        public CubicMile(double value) : base(value)
        {
        }

        public override string SiUnit => "mi³";
    }
}
