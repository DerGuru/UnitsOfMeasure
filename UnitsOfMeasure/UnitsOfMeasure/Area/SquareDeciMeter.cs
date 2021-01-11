using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareDeciMeter : Area
    {
        public SquareDeciMeter() { }

        public SquareDeciMeter(double value) : base(value) { }


        public SquareDeciMeter(BigFloat value) : base(value) { }

        public override string Unit => "dm²";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.01);
    }

}
