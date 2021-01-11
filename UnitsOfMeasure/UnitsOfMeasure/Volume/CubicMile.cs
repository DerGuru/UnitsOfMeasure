using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMile : Volume
    {
        public CubicMile() { }

        public CubicMile(double value) : base(value) { }

        public CubicMile(BigFloat value) : base(value) { }

        public override string Unit => "mi³";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(4168206689.375877890048);
    }
}
