using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Inch : Distance
    {
        public static BigDouble MetricFactor { get; } = new BigDouble(254, -4);
        public Inch() { }
        public Inch(BigDouble value) : base(value) { }
        public override string Unit => "\"";
        public override BigDouble FactorToBaseUnit { get; set; } = MetricFactor;
    }
}
