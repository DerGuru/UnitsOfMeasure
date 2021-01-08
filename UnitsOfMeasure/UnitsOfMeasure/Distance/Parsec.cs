using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Distances
{
    public class Parsec : Distance<Parsec>
    {
        public Parsec() { }

        public Parsec(double value) : base(value) { }

        public override string SiUnit => "pc";

        internal override double FactorToBaseUnit => 30856775814913673;
    }
}
