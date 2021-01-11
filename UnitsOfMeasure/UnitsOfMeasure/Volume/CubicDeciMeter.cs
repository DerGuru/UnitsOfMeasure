using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicDeciMeter : Volume
    {
        public CubicDeciMeter() { }

        public CubicDeciMeter(double value) : base(value) { }

        public CubicDeciMeter(BigFloat value) : base(value) { }

        public override string Unit => "dm³";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.001);
    }
}
