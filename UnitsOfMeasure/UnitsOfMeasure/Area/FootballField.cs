using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class FootballField : Area
    {
        public FootballField(){}

        public FootballField(double value) : base(value){}

        public FootballField(BigFloat value) : base(value){}
        public override string Unit => "FootballField(s)";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(445934592,100000);

    }
}
