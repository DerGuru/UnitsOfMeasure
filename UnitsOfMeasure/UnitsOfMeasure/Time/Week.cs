using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Week : Time
    {
        public Week() { }

        public Week(double value) : base(value) { }

        public Week(BigFloat value) : base(value) { }

        public override string Unit => "w";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(604800.0);
    }

}
