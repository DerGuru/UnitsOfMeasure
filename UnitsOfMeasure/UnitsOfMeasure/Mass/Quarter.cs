using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class Quarter : Mass<Quarter>
    {
        public Quarter()
        {
        }

        public Quarter(double value) : base(value)
        {
        }

        public override string SiUnit => "qu";

        internal override double FactorToBaseUnit => 12700.586360;
    }
}
