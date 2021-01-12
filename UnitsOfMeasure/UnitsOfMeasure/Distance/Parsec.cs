using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Parsec : Distance
    {
        public Parsec() { }

        public Parsec(double value) : base(value) { }

        public Parsec(BigDouble value) : base(value) { }

        public override string Unit => "pc";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(30856775814913673);
    }
}
