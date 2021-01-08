using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class Liter : Volume<DeciMeter>
    {
        public Liter()
        {
        }

        public Liter(double value) : base(value)
        {
        }

        public override string SiUnit => "l";

    }
}
