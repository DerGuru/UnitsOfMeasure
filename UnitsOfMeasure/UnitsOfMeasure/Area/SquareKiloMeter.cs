using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareKiloMeter : Area
    {
        public SquareKiloMeter() { }

        public SquareKiloMeter(double value) : base(value) { }

        public SquareKiloMeter(BigFloat value) : base(value) { }

        public override string Unit => "km²";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1000000);
    }

}
