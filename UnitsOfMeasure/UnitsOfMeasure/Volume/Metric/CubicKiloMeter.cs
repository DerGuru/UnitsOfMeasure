using System.Numerics;
namespace UnitsOfMeasure.Volumes
{
    public class CubicKiloMeter : Volume
    {
        public CubicKiloMeter() { }
        public CubicKiloMeter(BigDouble value) : base(value) { }
        public override string Unit => "km³";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, 9);
    }
}
