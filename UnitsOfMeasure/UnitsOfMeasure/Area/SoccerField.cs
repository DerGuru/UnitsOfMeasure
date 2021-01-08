using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SoccerField : Area<Meter>
    {
        public SoccerField() : this(1)
        {
        }

        public SoccerField(double value) : base(new Metervalue * 105, value * 68)
        {
        }

        public override string SiUnit => "SoccerField(s)";

        internal override double FactorToBaseUnit => 7140;
    }

}
