using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Hour : Time
    {
        public Hour() { }

        public Hour(double value) : base(value) { }

        public Hour(BigFloat value) : base(value) { }

        public override string Unit => "h";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(3600.0);
    }

}
