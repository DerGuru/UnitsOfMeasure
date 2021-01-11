using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Day : Time
    {
        public Day() { }

        public Day(double value) : base(value) { }

        public Day(BigFloat value) : base(value) { }

        public override string Unit => "d";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(86400.0);
    }

}
