
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicYard : Volume<Yard>
    {
        public CubicYard()
        {
        }

        public CubicYard(double value) : base(value)
        {
        }

        public override string SiUnit => "yd³";
    }
}
