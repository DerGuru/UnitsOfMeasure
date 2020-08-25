using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class TroyOunce : Mass<TroyOunce>
    {
        public TroyOunce()
        {
        }

        public TroyOunce(double value) : base(value)
        {
        }

        public override string SiUnit => "oz.tr.";

        internal override double FactorToBaseUnit => 31.1034768;
    }
}
