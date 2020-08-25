using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class Stone : Mass<Stone>
    {
        public Stone()
        {
        }

        public Stone(double value) : base(value)
        {
        }

        public override string SiUnit => "st";

        internal override double FactorToBaseUnit => 6350.293180;
    }
}
