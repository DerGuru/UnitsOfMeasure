using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class HectoLiter : Volume<Meter>
    {
        public HectoLiter() : this (1)
        {
        }

        public HectoLiter(double value) : base(value * 0.1)
        {
        }

        public override string SiUnit => "hl";
    }
}
