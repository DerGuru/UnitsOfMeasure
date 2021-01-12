using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicDeciMeter : Volume
    {
        public CubicDeciMeter() { }

        public CubicDeciMeter(double value) : base(value) { }

        public CubicDeciMeter(BigDouble value) : base(value) { }

        public override string Unit => "dm³";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, 3);
    }
}
