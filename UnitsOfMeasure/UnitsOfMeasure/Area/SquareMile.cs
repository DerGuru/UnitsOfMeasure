
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareMile : Area<Mile>
    {
        public SquareMile()
        {
        }

        public SquareMile(double value) : base(value)
        {
        }

        public override string SiUnit => "mi²";

        
    }

}
