
namespace UnitsOfMeasure.Times
{
    public class Month30d : Time
    {
        public Month30d()
        {
        }

        public Month30d(double value) : base(value)
        {
        }

        public override string SiUnit => "m";

        internal override double FactorToBaseUnit => 2592000.0;
    }

}
