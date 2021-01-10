using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class Hectar : Area
    {
        public Hectar() : this(1) { }
        public Hectar(double value) : base(value)
        {
            
        }

        public override string SiUnit => "ha";

        internal override double FactorToBaseUnit { get; } = 10000;
    }

}
