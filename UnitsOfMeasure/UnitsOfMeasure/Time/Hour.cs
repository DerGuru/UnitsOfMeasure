using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Times
{
    public class Hour : Time<Hour>
    {
        public Hour()
        {
        }

        public Hour(double value) : base(value)
        {
        }

        public override string SiUnit => "h";

        internal override double FactorToBaseUnit => 3600.0;
    }

}
