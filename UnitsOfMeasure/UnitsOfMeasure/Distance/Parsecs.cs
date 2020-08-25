using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Distances
{
    public class Parsecs : Distance<Parsecs>
    {
        public Parsecs() { }

        public Parsecs(double value) : base(value) { }

        public override string SiUnit => "pc";

        internal override double FactorToBaseUnit => 30856775814913673;
    }
}
