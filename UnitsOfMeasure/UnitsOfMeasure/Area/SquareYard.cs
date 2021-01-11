using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareYard : Area
    {
        public SquareYard() { }

        public SquareYard(double value) : base(value) { }

        public SquareYard(BigFloat value) : base(value) { }

        public override string Unit => "yd²";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(83612736, 100000000);
    }

}
