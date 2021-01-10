
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class Earth : Volume<Meter>
    {
        public Earth() 
        {
        }

        public Earth(double value) : base(value )
        {
        }

        public override string SiUnit => "Earth(s)";
        internal override double FactorToBaseUnit { get; } = 1083206916845753700547.1167989961;
    }
}
