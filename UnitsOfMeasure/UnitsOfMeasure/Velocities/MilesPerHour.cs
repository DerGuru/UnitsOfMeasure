using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class MilesPerHour : Velocity
    {
        public MilesPerHour() : this(1)
        {
        }
        public MilesPerHour(double value) : base(new Mile(value), new Hour())
        {
        }
    }
}
