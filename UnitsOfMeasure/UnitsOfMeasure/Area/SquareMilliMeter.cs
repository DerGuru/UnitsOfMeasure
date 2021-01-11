using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareMilliMeter : Area
    {
        public SquareMilliMeter() { }

        public SquareMilliMeter(double value) : base(value) { }

        public SquareMilliMeter(BigFloat value) : base(value) { }

        public override string Unit => "mm²";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1, 1000000);
    }

}
