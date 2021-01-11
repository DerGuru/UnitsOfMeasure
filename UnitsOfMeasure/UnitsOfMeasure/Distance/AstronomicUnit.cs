using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class AstronomicUnit : Distance
    {
        public AstronomicUnit() { }

        public AstronomicUnit(double value) : base(value) { }

        public AstronomicUnit(BigFloat value) : base(value) { }

        public override string Unit => "au";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(149597870700,1);
    }
}
