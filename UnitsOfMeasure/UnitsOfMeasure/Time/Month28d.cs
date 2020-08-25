using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Times
{
    public class Month28d : Time<Month28d>
    {
        public Month28d()
        {
        }

        public Month28d(double value) : base(value)
        {
        }
        public override string SiUnit => "m";
        internal override double FactorToBaseUnit => 2419200.0;
    }

}
