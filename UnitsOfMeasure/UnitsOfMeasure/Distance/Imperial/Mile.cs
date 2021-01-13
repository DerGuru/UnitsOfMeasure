using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Mile : Distance
    {
        public static BigDouble Inches { get; } = 63360;
        private static BigDouble factor = Inch.MetricFactor * Inches;
        public Mile() { }
        public Mile(BigDouble value) : base(value) { }
        public override string Unit => "mi";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }
}
