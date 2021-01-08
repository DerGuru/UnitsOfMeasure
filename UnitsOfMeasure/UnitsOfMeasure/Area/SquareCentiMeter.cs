using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareCentiMeter : Area<CentiMeter>
    {
        public SquareCentiMeter()
        {
        }

        public SquareCentiMeter(double value) : base(value)
        {
        }

        public override string SiUnit => "cm²";
    }
}
