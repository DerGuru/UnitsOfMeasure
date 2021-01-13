using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class AstronomicUnit : Distance
    {
        public AstronomicUnit() { }
        public AstronomicUnit(BigDouble value) : base(value) { }
        public override string Unit => "au";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1495978707,2);
    }
}
