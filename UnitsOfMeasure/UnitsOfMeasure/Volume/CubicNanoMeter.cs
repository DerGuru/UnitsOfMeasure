using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicNanoMeter : Volume
    {
        public CubicNanoMeter(){}

        public CubicNanoMeter(double value) : base(value){}

        public CubicNanoMeter(BigFloat value) : base(value){}

        public override string Unit => "nm³";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.000000000000000000000000001);
    }
}
