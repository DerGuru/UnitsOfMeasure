using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Pound : Mass
    {
        public Pound() { }

        public Pound(double value) : base(value) { }

        public Pound(BigFloat value) : base(value) { }

        public override string Unit => "lb";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(453.59237);
    }
}
