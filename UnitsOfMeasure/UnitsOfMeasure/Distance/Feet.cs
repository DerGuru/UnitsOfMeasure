using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure.Distances
{
    public class Feet : Distance<Feet>
    {
        public Feet() { }

        public Feet(double value) : base(value) { }

        public override string SiUnit => "'";

        internal override double FactorToBaseUnit => 0.3048;
    }
}
