using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Year : Time
    {
        public Year() { }

        public Year(double value) : base(value) { }

        public Year(BigFloat value) : base(value) { }

        public override string Unit => "y";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(31536000.0);
    }

}
