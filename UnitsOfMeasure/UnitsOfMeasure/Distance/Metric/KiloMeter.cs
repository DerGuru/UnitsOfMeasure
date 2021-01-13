using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class KiloMeter : Distance
    {
        public KiloMeter() { }
        public KiloMeter(BigDouble value) : base(value) { }
        public override string Unit => "km";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, 3);
    }
}
