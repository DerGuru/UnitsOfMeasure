using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Moon : Area
    {
        public Moon() { }

        public Moon(double value) : base(value) { }

        public Moon(BigFloat value) : base(value) { }

        public override string Unit => "Moon(s)";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(37932330000000);
    }

}
