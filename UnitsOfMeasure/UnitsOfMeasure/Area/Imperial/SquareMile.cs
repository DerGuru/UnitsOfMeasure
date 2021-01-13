using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareMile : Area
    {
        public static BigDouble Inches { get; } = Mile.Inches * Mile.Inches;
        private static readonly BigDouble factor = SquareInch.MetricFactor * Inches;
        public SquareMile() { }
        public SquareMile(BigDouble value) : base(value) { }
        public override string Unit => "mi²";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }

}
