using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class Hectar : Area<Hectar>
    {
        public Hectar()
        {
        }

        public Hectar(double value) : base(value)
        {
        }

        public override string SiUnit => "ha";

        internal override double FactorToBaseUnit => 10000;
    }

}
