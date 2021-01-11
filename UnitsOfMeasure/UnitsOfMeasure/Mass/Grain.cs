using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Grain : Mass
    {
        public Grain() { }

        public Grain(double value) : base(value) { }

        public Grain(BigFloat value) : base(value) { }

        public override string Unit => "gr";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.06479891);
    }
}
