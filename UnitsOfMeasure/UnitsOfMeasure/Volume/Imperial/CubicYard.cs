using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicYard : Volume
    {
        public static BigDouble Inches { get; } = Yard.Inches * Yard.Inches * Yard.Inches;
        private static readonly BigDouble factor = CubicInch.MetricFactor * Inches;
        public CubicYard() { }
        public CubicYard(BigDouble value) : base(value) { }
        public override string Unit => "yd³";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }
}
