using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareCentiMeter : Area
    {
        public SquareCentiMeter() { }

        public SquareCentiMeter(double value) : base(value) { }

        public SquareCentiMeter(BigDouble value) : base(value) { }

        public override string Unit => "cm²";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -4);

    }
}
