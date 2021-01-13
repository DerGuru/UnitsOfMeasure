using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareKiloMeter : Area
    {
        public SquareKiloMeter() { }
        public SquareKiloMeter(BigDouble value) : base(value) { }
        public override string Unit => "km²";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, 6);
    }
}
