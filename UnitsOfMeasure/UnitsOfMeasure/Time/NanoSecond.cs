
namespace UnitsOfMeasure.Times
{
    public class NanoSecond : Time
    {
        public NanoSecond()
        {
        }

        public NanoSecond(double value) : base(value)
        {
        }

        public override string SiUnit => "ns";

        internal override double FactorToBaseUnit => 0.000000001;
    }

}
