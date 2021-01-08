using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareMicroMeter : Area<MicroMeter>
    {
        public SquareMicroMeter()
        {
        }

        public SquareMicroMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "μm²";

        
    }

}
