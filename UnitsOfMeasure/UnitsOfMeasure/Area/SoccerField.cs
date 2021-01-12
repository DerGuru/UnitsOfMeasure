using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SoccerField : Area
    {
        private static Area field = new Meter(105) * new Meter(68);
        public SoccerField() { }

        public SoccerField(double value) : base(value) { }

        public SoccerField(BigDouble value) : base(value) { }

        public override string Unit => "SoccerField(s)";

        public override BigDouble FactorToBaseUnit { get; set; } = field.Value * field.FactorToBaseUnit;
    }
}
