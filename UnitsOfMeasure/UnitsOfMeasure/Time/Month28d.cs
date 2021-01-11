using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Month28d : Time
    {
        public Month28d() { }

        public Month28d(double value) : base(value) { }

        public Month28d(BigFloat value) : base(value) { }

        public override string Unit => "m";
        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(2419200.0);
    }

}
