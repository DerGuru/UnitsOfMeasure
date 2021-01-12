using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Inch : Distance
    {
        public static readonly BigDouble InchesPerMeter = new BigDouble(254, -4);
        public Inch() { }

        public Inch(double value) : base(value) { }

        public Inch(BigDouble value) : base(value) { }

        public override string Unit => "\"";

        public override BigDouble FactorToBaseUnit { get; set; } = InchesPerMeter;
    }
}
