using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Times
{
    public class Minute : Time<Minute>
    {
        public Minute()
        {
        }

        public Minute(double value) : base(value)
        {
        }

        public override string SiUnit => "min";

        internal override double FactorToBaseUnit => 60.0;
    }

}
