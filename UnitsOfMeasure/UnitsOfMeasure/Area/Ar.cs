using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Ar : Area
    {
        public Ar() { }

        public Ar(double value) : base(value) { }

        public Ar(BigFloat value) : base(value) { }

        public override string Unit => "a";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(100);
    }

}
