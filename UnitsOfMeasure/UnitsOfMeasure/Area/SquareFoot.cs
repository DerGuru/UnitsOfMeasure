using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareFoot : Area<Foot>
    {
        public SquareFoot() { }

        public SquareFoot(double value) : base(value) { }

        public override string SiUnit => "ft²";

    }

}
