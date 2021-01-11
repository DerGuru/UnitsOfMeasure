using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class MicroMeter : Distance
    {
        public MicroMeter() { }

        public MicroMeter(double value) : base(value) { }

        public MicroMeter(BigFloat value) : base(value) { }

        public override string Unit => "μm";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1,1000000);
    }
}
