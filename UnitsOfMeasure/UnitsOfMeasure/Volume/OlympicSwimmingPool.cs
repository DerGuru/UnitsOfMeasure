using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class OlympicSwimmingPool : Volume<Meter>
    {
        public OlympicSwimmingPool() : this(1)
        {
        }

        public OlympicSwimmingPool(double value) : base(value * 2500)
        {
        }

        public override string SiUnit => "Olympic Swimming Pool(s)";

        internal override double FactorToBaseUnit => 2500;
    }
}
