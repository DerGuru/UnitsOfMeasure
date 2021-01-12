using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicFoot : Volume
    {
        public static readonly BigDouble CbInches = Foot.Inches * Foot.Inches * Foot.Inches;
        public CubicFoot() { }

        public CubicFoot(double value) : base(value) { }

        public CubicFoot(BigDouble value) : base(value) { }

        public override string Unit => "ft³";

        public override BigDouble FactorToBaseUnit { get; set; } = CubicInch.CubicInchesPerCubicMeter * CbInches;
    }
}
