using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class SolarSystem : Volume
    {
        public SolarSystem() { }
        public SolarSystem(BigDouble value) : base(value) { }
        public override string Unit => "Solar System(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = VolumeInMeter;
        public static BigDouble VolumeInMeter { get; } = GetVolume();
        public static BigDouble GetVolume()
        {
              var volume = CreateSphere(new Distances.AstronomicUnit(30));
              return volume.Value * volume.FactorToBaseUnit;
          }
    }
}
