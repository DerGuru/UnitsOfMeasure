using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMicroMeter : Volume
    {
        public CubicMicroMeter(){}

        public CubicMicroMeter(double value) : base(value){}

        public CubicMicroMeter(BigFloat value) : base(value){}

        public override string Unit => "μm³";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.000000000000000001);
    }
}
