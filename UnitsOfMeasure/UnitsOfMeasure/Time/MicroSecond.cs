
namespace UnitsOfMeasure.Times
{
    public class MicroSecond : Time
    {
        public MicroSecond()
        {
        }

        public MicroSecond(double value) : base(value)
        {
        }

        public override string SiUnit => "μs";

        internal override double FactorToBaseUnit => 0.000001;
    }

}
