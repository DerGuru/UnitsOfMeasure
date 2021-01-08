using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareKiloMeter : Area<KiloMeter>
    {
        public SquareKiloMeter()
        {
        }

        public SquareKiloMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "km²";

       
    }

}
