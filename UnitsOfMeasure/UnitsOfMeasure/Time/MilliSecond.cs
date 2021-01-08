
namespace UnitsOfMeasure.Times
{
    public class MilliSecond : Time
    {
        public MilliSecond()
        {
        }

        public MilliSecond(double value) : base(value)
        {
        }

        public override string SiUnit => "ms";

        internal override double FactorToBaseUnit => 0.001;
    }

}
