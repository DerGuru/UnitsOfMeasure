using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicCentiMeter : Volume
    {
        public CubicCentiMeter() { }

        public CubicCentiMeter(double value) : base(value) { }

        public CubicCentiMeter(BigDouble value) : base(value) { }

        public override string Unit => "cm³";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,-6);
    }
}
