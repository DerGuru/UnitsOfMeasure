using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMilliMeter : Volume
    {
        public CubicMilliMeter() { }
        public CubicMilliMeter(BigDouble value) : base(value) { }
        public override string Unit => "mm³";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,-9);
    }
}
