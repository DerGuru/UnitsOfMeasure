using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareDeciMeter : Area
    {
        public SquareDeciMeter() { }
        public SquareDeciMeter(BigDouble value) : base(value) { }
        public override string Unit => "dm²";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -2);
    }

}
