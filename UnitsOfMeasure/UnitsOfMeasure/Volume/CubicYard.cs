using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class CubicYard : Volume<CubicYard>
    {
        public CubicYard()
        {
        }

        public CubicYard(double value) : base(value)
        {
        }

        public override string SiUnit => "yd³";

        internal override double FactorToBaseUnit => 0.764554857984;
    }
}
