using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class Moon : Area
    {
        public Moon() : this (1)
        {
        }

        public Moon(double value) : base(value)
        {
            
        }

        public override string SiUnit => "Moon(s)";

        internal override double FactorToBaseUnit => 37932330000000;
    }

}
