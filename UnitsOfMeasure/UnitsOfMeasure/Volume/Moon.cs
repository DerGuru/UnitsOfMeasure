using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class Moon : Volume<Meter>
    {
        public Moon() 
        {
        }

        public Moon(double value) : base(value)
        {
        }

        public override string SiUnit => "Moon(s)";

        internal override double FactorToBaseUnit => 21990642870864709217.827712858943;
    }
}
