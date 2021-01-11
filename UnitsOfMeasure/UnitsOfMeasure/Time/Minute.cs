using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Minute : Time
    {
        public Minute() { }

        public Minute(double value) : base(value) { }

        public Minute(BigFloat value) : base(value) { }

        public override string Unit => "min";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(60.0);
    }

}
