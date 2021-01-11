using System.Numerics;
namespace UnitsOfMeasure.Volumes
{
    public class CubicKiloMeter : Volume
    {
        public CubicKiloMeter() { }

        public CubicKiloMeter(double value) : base(value) { }

        public CubicKiloMeter(BigFloat value) : base(value) { }

        public override string Unit => "km³";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1000000000);
    }
}
