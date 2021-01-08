using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class Earth : Area<KiloMeter>
    {
        public Earth() : this (1)
        {
        }

        public Earth(double value) : base(value * 510000000)
        {
        }

        public override string SiUnit => "Earth(s)";

        internal override double FactorToBaseUnit => 510000000000000;
    }

}
