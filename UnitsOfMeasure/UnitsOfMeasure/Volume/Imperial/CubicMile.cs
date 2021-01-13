using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMile : Volume
    {
        public static BigDouble Inches { get; } = Mile.Inches * Mile.Inches * Mile.Inches;
        private static readonly BigDouble factor = CubicInch.MetricFactor * Inches;
        public CubicMile() { }
        public CubicMile(BigDouble value) : base(value) { }
        public override string Unit => "mi³";
        public override BigDouble FactorToBaseUnit { get; set; } =  factor;
    }
}
