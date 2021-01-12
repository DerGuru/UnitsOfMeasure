using System.Numerics;
using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class MilesPerHour : Velocity<Mile,Hour>
    {
        public MilesPerHour(){}

        public MilesPerHour(double value) : base(value){}

        public MilesPerHour(BigDouble value) : base(value){}
    }
}
