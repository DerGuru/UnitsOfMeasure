using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class MilliMeter : Distance
    {
        public MilliMeter() { }

        public MilliMeter(double value) : base(value) { }

        public MilliMeter(BigFloat value) : base(value) { }

        public override string Unit => "mm";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1,1000);
    }
}
