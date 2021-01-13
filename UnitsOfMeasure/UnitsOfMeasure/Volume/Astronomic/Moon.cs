using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class Moon : Volume
    {
        public Moon() { }
        public Moon(BigDouble value) : base(value) { }
        public override string Unit => "Moon(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(21990642870864709217827712858943.0, 12);
    }
}
