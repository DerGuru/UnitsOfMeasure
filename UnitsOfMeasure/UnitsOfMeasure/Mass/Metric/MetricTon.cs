using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class MetricTon : Mass
    {
        public MetricTon() { }
        public MetricTon(BigDouble value) : base(value) { }
        public override string Unit => "t";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, 6);
    }
}
