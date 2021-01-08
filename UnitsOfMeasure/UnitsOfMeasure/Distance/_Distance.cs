
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure
{
    public abstract class Distance : UnitOfMeasure<Distance>
    {
        protected Distance() : this(1) { } 
        protected Distance(double value) : base(value) { }
        
        public static Velocity operator / (Distance d, Time t)
        {
            return new Velocity(d,t);
        }
        public static Area operator * (Distance a, Distance b)
        {
            return new Areas.SquareMeter(a.Convert<Meter>().Value * b.Convert<Meter>().Value);
        }

        
    }
}
