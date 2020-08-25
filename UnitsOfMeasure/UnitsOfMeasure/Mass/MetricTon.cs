using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class MetricTon : Mass<MetricTon>
    {
        public MetricTon()
        {
        }

        public MetricTon(double value) : base(value)
        {
        }

        public override string SiUnit => "t";

        internal override double FactorToBaseUnit => 1000000;
    }
}
