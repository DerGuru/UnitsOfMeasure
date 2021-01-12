using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicYard : Volume
    {
        public static readonly BigDouble CbInches = Yard.Inches * Yard.Inches * Yard.Inches;
        public CubicYard() { }

        public CubicYard(double value) : base(value) { }

        public CubicYard(BigDouble value) : base(value) { }

        public override string Unit => "yd³";

        public override BigDouble FactorToBaseUnit { get; set; } = CubicInch.CubicInchesPerCubicMeter * CbInches;
    }
}
