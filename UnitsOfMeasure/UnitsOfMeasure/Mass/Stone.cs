using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Stone : Mass
    {
        public Stone() { }

        public Stone(double value) : base(value) { }

        public Stone(BigFloat value) : base(value) { }

        public override string Unit => "st";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(6350.293180);
    }
}
