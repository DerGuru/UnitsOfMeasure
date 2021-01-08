using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SoccerField : Area<Meter>
    {
        public SoccerField() : this(1)
        {
        }

        public SoccerField(double value) : base(value * 105, value * 68)
        {
        }

        public override string SiUnit => "SoccerField(s)";
    }

}
