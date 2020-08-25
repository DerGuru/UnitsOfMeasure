using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class Saarland : Area<Saarland>
    {
        public Saarland()
        {
        }

        public Saarland(double value) : base(value)
        {
        }

        public override string SiUnit => "Saarla(e)nd(er)";

        internal override double FactorToBaseUnit => 2570000000;
    }

}
