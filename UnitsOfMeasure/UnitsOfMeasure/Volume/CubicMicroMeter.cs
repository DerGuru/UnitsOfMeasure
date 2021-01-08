using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMicroMeter : Volume<MicroMeter>
    {
        public CubicMicroMeter()
        {
        }

        public CubicMicroMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "μm³";

    }
}
