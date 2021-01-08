
namespace UnitsOfMeasure.Times
{
    public class Second : Time
    {
        public Second()
        {
        }

        public Second(double value) : base(value)
        {
        }

        public override string SiUnit => "s";

        internal override double FactorToBaseUnit => 1.0;
    }

}
