using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicInch : Volume<Inch>
    {
        public CubicInch()
        {
        }

        public CubicInch(double value) : base(value)
        {
        }

        public override string SiUnit => "in³";
    }
}
