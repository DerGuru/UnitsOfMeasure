using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareInch : Area
    {
        public SquareInch() { }

        public SquareInch(double value) : base(value) { }

        public SquareInch(BigFloat value) : base(value) { }

        public override string Unit => "in²";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(64516, 100000000);
    }

}
