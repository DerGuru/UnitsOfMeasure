using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class Liter : Volume<Liter>
    {
        public Liter()
        {
        }

        public Liter(double value) : base(value)
        {
        }

        public override string SiUnit => "l";

        internal override double FactorToBaseUnit => 0.001;
    }
}
