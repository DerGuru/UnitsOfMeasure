using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicInch : Volume
    {
        public CubicInch() { }

        public CubicInch(double value) : base(value) { }

        public CubicInch(BigFloat value) : base(value) { }

        public override string Unit => "in³";
        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.000016387064);
    }
}
