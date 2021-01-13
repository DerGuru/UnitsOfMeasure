using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class MicroMeter : Distance
    {
        public MicroMeter() { }
        public MicroMeter(BigDouble value) : base(value) { }
        public override string Unit => "μm";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,-6);
    }
}
