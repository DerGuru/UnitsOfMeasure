using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMeter : Volume
    {
        public CubicMeter() { }

        public CubicMeter(double value) : base(value) { }

        public CubicMeter(BigDouble value) : base(value) { }

        public override string Unit => "m³";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1);
    }
}
