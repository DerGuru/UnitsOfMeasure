
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class Earth : Volume<Meter>
    {
        public Earth() : this (1)
        {
        }

        public Earth(double value) : base(value * 1083206916845753700547.1167989961)
        {
        }

        public override string SiUnit => "Earth(s)";

    }
}
