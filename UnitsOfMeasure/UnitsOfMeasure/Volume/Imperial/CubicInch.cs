using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicInch : Volume
    {
        public static readonly BigDouble MetricFactor = Inch.MetricFactor * Inch.MetricFactor * Inch.MetricFactor;
        public CubicInch() { }
        public CubicInch(BigDouble value) : base(value) { }
        public override string Unit => "in³";
        public override BigDouble FactorToBaseUnit { get; set; } = MetricFactor;
    }
}
