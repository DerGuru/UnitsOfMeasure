using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Distances
{
    public class Meters : Distance<Meters>
    {
        public Meters() { }

        public Meters(double value) : base(value) { }

        public override string SiUnit => "m";

        internal override double FactorToBaseUnit => 1;
    }
}
