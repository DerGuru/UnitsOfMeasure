using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Moon : Mass
    {
        public Moon() { }

        public Moon(double value) : base(value) { }

        public Moon(BigFloat value) : base(value) { }

        public override string Unit => "Moon(s)";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(73480000000000000000000000.0);
    }
}
