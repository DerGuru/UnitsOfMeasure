using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareNanoMeter : Area
    {
        public SquareNanoMeter() { }

        public SquareNanoMeter(double value) : base(value) { }

        public SquareNanoMeter(BigDouble value) : base(value) { }

        public override string Unit => "nm²";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -18);
    }

}
