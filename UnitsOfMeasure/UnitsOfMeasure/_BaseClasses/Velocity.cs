using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure
{
    public class Velocity : DivisionCompound<Velocity, Distance, Time>
    {
        public Velocity(Distance distance, Time time) : base(distance, time) { }
    }

    public class Velocity<DistanceType, TimeType> : DivisionCompound<Velocity, Distance, Time> where DistanceType : Distance,new() where TimeType : Time, new()
    {
        public Velocity() : base(new DistanceType(), new TimeType()) { }
        public Velocity(double distance, double time) : base(distance * new DistanceType(), time * new TimeType()) { }
    }
}
