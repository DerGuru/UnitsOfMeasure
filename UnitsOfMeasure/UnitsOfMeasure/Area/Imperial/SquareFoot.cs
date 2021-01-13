using System;
using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareFoot : Area
    {
        public static BigDouble Inches { get; } = Foot.Inches * Foot.Inches;
        private static readonly BigDouble factor = SquareInch.MetricFactor * Inches;
        public SquareFoot() { }
        public SquareFoot(BigDouble value) : base(value) { }
        public override string Unit => "ft²";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }

}
