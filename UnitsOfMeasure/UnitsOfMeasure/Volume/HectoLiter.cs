using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class HectoLiter : Volume<HectoLiter>
    {
        public HectoLiter()
        {
        }

        public HectoLiter(double value) : base(value)
        {
        }

        public override string SiUnit => "hl";

        internal override double FactorToBaseUnit => 0.1;
    }
}
