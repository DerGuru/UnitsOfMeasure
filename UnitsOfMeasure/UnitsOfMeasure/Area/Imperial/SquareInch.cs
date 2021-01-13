using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareInch : Area
    {
        public static BigDouble MetricFactor { get; } = Inch.MetricFactor * Inch.MetricFactor;
        public SquareInch() { }
        public SquareInch(BigDouble value) : base(value) { }
        public override string Unit => "in²";
        public override BigDouble FactorToBaseUnit { get; set; } = MetricFactor;
    }

}
