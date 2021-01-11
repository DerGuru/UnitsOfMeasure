using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SoccerField : Area
    {
        public SoccerField() { }

        public SoccerField(double value) : base(value) { }

        public SoccerField(BigFloat value) : base(value) { }

        public override string Unit => "SoccerField(s)";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(7140);
    }
}
