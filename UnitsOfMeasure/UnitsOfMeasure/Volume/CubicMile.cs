using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicMile : Volume
    {
        public static readonly BigDouble CbInches = Mile.Inches * Mile.Inches * Mile.Inches;
        public CubicMile() { }

        public CubicMile(double value) : base(value) { }

        public CubicMile(BigDouble value) : base(value) { }

        public override string Unit => "mi³";

        public override BigDouble FactorToBaseUnit { get; set; } = CubicInch.CubicInchesPerCubicMeter * CbInches;
    }
}
