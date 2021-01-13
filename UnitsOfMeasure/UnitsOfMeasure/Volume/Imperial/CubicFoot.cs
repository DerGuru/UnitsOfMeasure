using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicFoot : Volume
    {
        public static BigDouble Inches { get; } = Foot.Inches * Foot.Inches * Foot.Inches;
        private static readonly BigDouble factor = CubicInch.MetricFactor * Inches;
        public CubicFoot() { }
        public CubicFoot(BigDouble value) : base(value) { }
        public override string Unit => "ft³";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }
}
