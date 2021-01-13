using System.Numerics;

namespace UnitsOfMeasure.Velocities
{
    public class KiloMetersPerHour : Velocity
    {
        private static BigDouble GetFactor() => (new Distances.KiloMeter(1) / new Times.Hour(1)).FactorToBaseUnit;
        private static readonly BigDouble factor = GetFactor();
        public KiloMetersPerHour() { }
        public KiloMetersPerHour(BigDouble value) : base(value) { }
        public override string Unit { get; set; } = "km/h";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }

    public class MetersPerSecond : Velocity
    {
        private static BigDouble GetFactor() => (new Distances.Meter(1) / new Times.Second(1)).FactorToBaseUnit;
        private static readonly BigDouble factor = GetFactor();
        public MetersPerSecond() { }
        public MetersPerSecond(BigDouble value) : base(value) { }
        public override string Unit { get; set; } = "m/s";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }
}
