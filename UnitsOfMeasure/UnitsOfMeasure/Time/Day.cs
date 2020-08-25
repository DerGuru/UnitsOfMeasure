using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Times
{
    public class Day : Time<Day>
    {
        public Day()
        {
        }

        public Day(double value) : base(value)
        {
        }

        public override string SiUnit => "d";

        internal override double FactorToBaseUnit => 86400.0;
    }

}
