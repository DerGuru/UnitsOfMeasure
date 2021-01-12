using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareMile : Area
    {
        public static readonly BigDouble SqInches = Mile.Inches * Mile.Inches;
        public SquareMile() { }

        public SquareMile(double value) : base(value) { }

        public SquareMile(BigDouble value) : base(value) { }

        public override string Unit => "mi²";
        public override BigDouble FactorToBaseUnit { get; set; } = SquareInch.SquareInchesPerSquareMeter * SqInches;
    }

}
