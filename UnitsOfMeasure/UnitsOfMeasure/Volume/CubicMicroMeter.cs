using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMicroMeter : Volume
    {
        public CubicMicroMeter(){}

        public CubicMicroMeter(double value) : base(value){}

        public CubicMicroMeter(BigDouble value) : base(value){}

        public override string Unit => "μm³";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -18);
    }
}
