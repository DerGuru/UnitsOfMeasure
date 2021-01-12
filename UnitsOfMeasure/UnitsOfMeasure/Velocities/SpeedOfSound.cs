using System.Numerics;
using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class Mach : Velocity<Meter, Second>
    {
        public Mach(){}

        public Mach(double value) : base(value){}

        public Mach(BigDouble value) : base(value){}

        public override string Unit => "Mach";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(343);
    }
}
