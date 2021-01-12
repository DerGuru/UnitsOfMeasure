using System;
using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareFoot : Area
    {
        public static readonly BigDouble SqInches = Foot.Inches * Foot.Inches;
        public SquareFoot() { }

        public SquareFoot(double value) : base(value) { }

        public SquareFoot(BigDouble value) : base(value) { }

        public override string Unit => "ft²";

        public override BigDouble FactorToBaseUnit { get; set; } = SquareInch.SquareInchesPerSquareMeter * SqInches;
    }

}
