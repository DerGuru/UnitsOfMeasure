
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicCentiMeter : Volume<CentiMeter>
    {
        public CubicCentiMeter()
        {
        }

        public CubicCentiMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "cm³";

        internal override double FactorToBaseUnit => 0.000001;
    }
}
