
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareMicroMeter : Area
    {
        public SquareMicroMeter()
        {
        }

        public SquareMicroMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "μm²";

        internal override double FactorToBaseUnit { get; } = 0.000000000001;
    }

}
