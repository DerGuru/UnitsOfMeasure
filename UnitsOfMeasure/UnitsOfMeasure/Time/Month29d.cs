using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Times
{
    public class Month29d : Time<Month29d>
    {
        public Month29d()
        {
        }

        public Month29d(double value) : base(value)
        {
        }
        public override string SiUnit => "m";
        internal override double FactorToBaseUnit => 2505600.0;
    }

}
