using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Volumes
{
    public class CubicInch : Volume
    {
        public static readonly BigDouble CubicInchesPerCubicMeter = Inch.InchesPerMeter * Inch.InchesPerMeter * Inch.InchesPerMeter;
        public CubicInch() { }

        public CubicInch(double value) : base(value) { }

        public CubicInch(BigDouble value) : base(value) { }

        public override string Unit => "in³";
        public override BigDouble FactorToBaseUnit { get; set; } = CubicInchesPerCubicMeter;
    }
}
