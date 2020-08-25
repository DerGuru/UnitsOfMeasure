using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class Ar : Area<Ar>
    {
        public Ar()
        {
        }

        public Ar(double value) : base(value)
        {
        }

        public override string SiUnit => "a";

        internal override double FactorToBaseUnit => 100;
    }

}
