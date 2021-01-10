using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SoccerField : Area
    {
        public SoccerField() : this(1)
        {
        }

        public SoccerField(double value) : base(value)
        {
        }

        public override string SiUnit => "SoccerField(s)";

        internal override double FactorToBaseUnit => 7140;
    }

}
