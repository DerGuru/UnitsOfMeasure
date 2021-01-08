using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class Moon : Volume<Meter>
    {
        public Moon() : this (1)
        {
        }

        public Moon(double value) : base(value * 21990642870864709217.827712858943)
        {
        }

        public override string SiUnit => "Moon(s)";

    }
}
