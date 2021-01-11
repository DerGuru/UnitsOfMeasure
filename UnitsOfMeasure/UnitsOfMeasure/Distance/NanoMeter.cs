using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class NanoMeter : Distance
    {
        public NanoMeter() { }

        public NanoMeter(double value) : base(value) { }

        public NanoMeter(BigFloat value) : base(value) { }

        public override string Unit => "nm";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1,1000000000);
    }
}
