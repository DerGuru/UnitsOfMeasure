
using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure
{
    public class Distance : UnitOfMeasure<Distance>
    {
        public Distance() { }
        public Distance(double value) : base(value) { }
        public Distance(BigDouble value) : base(value) { }

        public static Velocity operator /(Distance d, Time t) =>  Divide(d, t, new Velocity());
        public static Area operator * (Distance a, Distance b) => Multiply(a, b, new Area());
       
    }
}
