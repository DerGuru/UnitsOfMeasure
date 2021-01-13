using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareMicroMeter : Area
    {
        public SquareMicroMeter() { }
        public SquareMicroMeter(BigDouble value) : base(value) { }
        public override string Unit => "μm²";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,-12);
    }
}
