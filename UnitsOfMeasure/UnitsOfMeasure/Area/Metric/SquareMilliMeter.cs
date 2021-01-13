using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareMilliMeter : Area
    {
        public SquareMilliMeter() { }
        public SquareMilliMeter(BigDouble value) : base(value) { }
        public override string Unit => "mm²";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,-6);
    }
}
