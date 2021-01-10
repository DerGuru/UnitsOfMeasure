using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class Saarland : Area
    {
        public Saarland() : this (1)
        {
        }

        public Saarland(double value) : base(value)
        {
            
        }

        public override string SiUnit => "Saarla(e)nd(er)";

        internal override double FactorToBaseUnit => 2570000000;
    }

}
