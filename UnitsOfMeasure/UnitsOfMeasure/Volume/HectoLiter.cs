
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class HectoLiter : Volume<Meter>
    {
        public HectoLiter() : this (1)
        {
        }

        public HectoLiter(double value) : base(value)
        {
        }

        public override string SiUnit => "hl";

        internal override double FactorToBaseUnit { get; } = 0.1;
    }
}
