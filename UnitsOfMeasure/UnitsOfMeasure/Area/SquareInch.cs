using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareInch : Area
    {
        public static readonly BigDouble SquareInchesPerSquareMeter = Inch.InchesPerMeter * Inch.InchesPerMeter;
        public SquareInch() { }

        public SquareInch(double value) : base(value) { }

        public SquareInch(BigDouble value) : base(value) { }

        public override string Unit => "in²";

        public override BigDouble FactorToBaseUnit { get; set; } = SquareInchesPerSquareMeter;
        
    }

}
