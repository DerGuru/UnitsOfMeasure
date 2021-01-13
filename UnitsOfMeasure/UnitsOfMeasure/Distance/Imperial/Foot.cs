using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Foot : Distance
    {
        public static readonly BigDouble Inches = 12;
        private static BigDouble factor = Inch.MetricFactor * Inches;
        public Foot() { }
        public Foot(BigDouble value) : base(value) { }
        public override string Unit => "'";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }
}
