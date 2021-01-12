using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareYard : Area
    {
        public static readonly BigDouble SqInches = Yard.Inches * Yard.Inches;
        public SquareYard() { }

        public SquareYard(double value) : base(value) { }

        public SquareYard(BigDouble value) : base(value) { }

        public override string Unit => "yd²";
        public override BigDouble FactorToBaseUnit { get; set; } = SquareInch.SquareInchesPerSquareMeter * SqInches;
    }

}
