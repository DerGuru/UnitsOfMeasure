using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicYard : Volume
    {
        public CubicYard() { }

        public CubicYard(double value) : base(value) { }

        public CubicYard(BigFloat value) : base(value) { }

        public override string Unit => "yd³";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.764554857984);
    }
}
