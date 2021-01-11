using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Month30d : Time
    {
        public Month30d() { }

        public Month30d(double value) : base(value) { }

        public Month30d(BigFloat value) : base(value) { }

        public override string Unit => "m";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(2592000.0);
    }

}
