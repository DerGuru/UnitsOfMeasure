using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareNanoMeter : Area
    {
        public SquareNanoMeter() { }

        public SquareNanoMeter(double value) : base(value) { }

        public SquareNanoMeter(BigFloat value) : base(value) { }

        public override string Unit => "nm²";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1, 1000000000000000000);
    }

}
