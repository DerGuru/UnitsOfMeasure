using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class Pound : Mass<Pound>
    {
        public Pound()
        {
        }

        public Pound(double value) : base(value)
        {
        }

        public override string SiUnit => "lb";

        internal override double FactorToBaseUnit => 453.59237;
    }
}
