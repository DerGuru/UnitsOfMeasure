using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Month29d : Time
    {
        public Month29d() { }

        public Month29d(double value) : base(value) { }

        public Month29d(BigFloat value) : base(value) { }

        public override string Unit => "m";
        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(2505600.0);
    }

}
