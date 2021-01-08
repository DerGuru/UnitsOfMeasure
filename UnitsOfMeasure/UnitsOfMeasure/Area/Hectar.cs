using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class Hectar : Area<Meter>
    {
        public Hectar() : this (1)
        {
        }

        public Hectar(double value) : base(value * 10000)
        {
        }

        public override string SiUnit => "ha";

        
    }

}
