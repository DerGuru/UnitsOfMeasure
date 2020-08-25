using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class SoccerField : Area<SoccerField>
    {
        public SoccerField()
        {
        }

        public SoccerField(double value) : base(value)
        {
        }

        public override string SiUnit => "SoccerField(s)";

        internal override double FactorToBaseUnit => 7140;
    }

}
