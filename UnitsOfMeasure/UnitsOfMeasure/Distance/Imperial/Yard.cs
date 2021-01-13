using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Yard : Distance
    {
        public static BigDouble Inches { get; } = 36;
        private static BigDouble factor = Inch.MetricFactor * Inches;
        public Yard() { }
        public Yard(BigDouble value) : base(value) { }
        public override string Unit => "yd";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }
}
