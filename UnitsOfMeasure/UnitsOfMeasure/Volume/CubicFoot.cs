using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicFoot : Volume<Foot>
    {
        public CubicFoot()
        {
        }

        public CubicFoot(double value) : base(value)
        {
        }

        public override string SiUnit => "ft³";

    }
}
