using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class MilliMeter : Distance
    {
        public MilliMeter() { }

        public MilliMeter(double value) : base(value) { }

        public MilliMeter(BigDouble value) : base(value) { }

        public override string Unit => "mm";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -3);
    }
}
