using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Parsec : Distance
    {
        public Parsec() { }

        public Parsec(double value) : base(value) { }

        public Parsec(BigFloat value) : base(value) { }

        public override string Unit => "pc";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(30856775814913673,1);
    }
}
