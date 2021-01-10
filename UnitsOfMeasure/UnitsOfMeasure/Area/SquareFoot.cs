
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareFoot : Area
    {
       

        public override string SiUnit => "ft²";

        internal override double FactorToBaseUnit => 0.092903;
    }

}
