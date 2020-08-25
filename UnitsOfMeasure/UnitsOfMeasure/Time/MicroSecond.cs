using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Times
{
    public class MicroSecond : Time<MicroSecond>
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
