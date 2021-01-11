using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicCentiMeter : Volume
    {
        public CubicCentiMeter() { }

        public CubicCentiMeter(double value) : base(value) { }

        public CubicCentiMeter(BigFloat value) : base(value) { }

        public override string Unit => "cm³";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.000001);
    }
}
