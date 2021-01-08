
namespace UnitsOfMeasure.Times
{
    public class Month31d : Time
    {
        public Month31d()
        {
        }

        public Month31d(double value) : base(value)
        {
        }
        public override string SiUnit => "m";
        internal override double FactorToBaseUnit => 2678400.0;
    }

}
