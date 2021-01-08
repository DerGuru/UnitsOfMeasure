
namespace UnitsOfMeasure.Times
{
    public class Day : Time
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
