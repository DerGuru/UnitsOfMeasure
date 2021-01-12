using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class FootballField : Area
    {
        private static readonly Area field = new Yard(100) * new Foot(160);
        public FootballField(){}

        public FootballField(double value) : base(value){}

        public FootballField(BigDouble value) : base(value){}
        public override string Unit => "FootballField(s)";

        public override BigDouble FactorToBaseUnit { get; set; } = field.Value * field.FactorToBaseUnit;

    }
}
