using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class Moon : Volume
    {
        public Moon() { }

        public Moon(double value) : base(value) { }

        public Moon(BigFloat value) : base(value) { }

        public override string Unit => "Moon(s)";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(21990642870864709217.827712858943);
    }
}
