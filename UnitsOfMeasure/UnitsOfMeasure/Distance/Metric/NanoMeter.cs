using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class NanoMeter : Distance
    {
        public NanoMeter() { }
        public NanoMeter(BigDouble value) : base(value) { }
        public override string Unit => "nm";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,-9);
    }
}
