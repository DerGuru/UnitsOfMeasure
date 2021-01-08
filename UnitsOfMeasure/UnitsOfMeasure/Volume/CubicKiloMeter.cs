using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicKiloMeter : Volume<KiloMeter>
    {
        public CubicKiloMeter()
        {
        }

        public CubicKiloMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "km³";
    }
}
