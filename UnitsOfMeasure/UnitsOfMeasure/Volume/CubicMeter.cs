using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMeter : Volume
    {
        public CubicMeter() { }

        public CubicMeter(double value) : base(value) { }

        public CubicMeter(BigFloat value) : base(value) { }

        public override string Unit => "m³";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1);
    }
}
