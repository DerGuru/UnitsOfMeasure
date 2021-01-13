using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareCentiMeter : Area
    {
        public SquareCentiMeter() { }
        public SquareCentiMeter(BigDouble value) : base(value) { }
        public override string Unit => "cm²";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -4);
    }
}
