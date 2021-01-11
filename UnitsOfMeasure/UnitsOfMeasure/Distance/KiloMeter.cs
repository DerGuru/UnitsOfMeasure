using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class KiloMeter : Distance
    {
        public KiloMeter() { }

        public KiloMeter(double value) : base(value) { }

        public KiloMeter(BigFloat value) : base(value) { }

        public override string Unit => "km";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1000,1);
    }
}
