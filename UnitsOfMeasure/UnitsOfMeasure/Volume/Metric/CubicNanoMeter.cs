using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class CubicNanoMeter : Volume
    {
        public CubicNanoMeter(){}
        public CubicNanoMeter(double value) : base(value){}
        public CubicNanoMeter(BigDouble value) : base(value){}
        public override string Unit => "nm³";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -27);
    }
}
