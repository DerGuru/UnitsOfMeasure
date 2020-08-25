using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Times
{
    public class Week : Time<Week>
    {
        public Week()
        {
        }

        public Week(double value) : base(value)
        {
        }

        public override string SiUnit => "w";

        internal override double FactorToBaseUnit => 604800.0;
    }

}
