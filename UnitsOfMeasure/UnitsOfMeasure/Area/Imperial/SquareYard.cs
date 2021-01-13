using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareYard : Area
    {
        public static BigDouble Inches { get; } = Yard.Inches * Yard.Inches;
        private static readonly BigDouble factor = SquareInch.MetricFactor * Inches;
        public SquareYard() { }
        public SquareYard(BigDouble value) : base(value) { }
        public override string Unit => "yd²";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }

}
