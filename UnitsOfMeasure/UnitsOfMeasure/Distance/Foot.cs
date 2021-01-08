using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure.Distances
{
    public class Foot : Distance<Foot>
    {
        public Foot() { }

        public Foot(double value) : base(value) { }

        public override string SiUnit => "'";

        internal override double FactorToBaseUnit => 0.3048;
    }
}
