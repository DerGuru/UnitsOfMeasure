using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicFoot : Volume
    {
        public CubicFoot() { }

        public CubicFoot(double value) : base(value) { }

        public CubicFoot(BigFloat value) : base(value) { }

        public override string Unit => "ft³";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.028316846592);
    }
}
