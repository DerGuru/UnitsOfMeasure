using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class Gramm : Mass<Gramm>
    {
        public Gramm()
        {
        }

        public Gramm(double value) : base(value)
        {
        }

        public override string SiUnit => "g";

        internal override double FactorToBaseUnit => 1;
    }
}
