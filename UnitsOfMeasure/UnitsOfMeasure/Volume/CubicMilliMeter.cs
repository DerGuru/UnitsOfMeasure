using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMilliMeter : Volume
    {
        public CubicMilliMeter() { }

        public CubicMilliMeter(double value) : base(value) { }

        public CubicMilliMeter(BigFloat value) : base(value) { }

        public override string Unit => "mm³";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.000000001);
    }
}
