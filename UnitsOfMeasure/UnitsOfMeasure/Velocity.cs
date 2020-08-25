using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure
{
    public class Velocity : DivisionCompound<Velocity, Distance, Time>
    {
        public Velocity()
        {
        }

        public Velocity(Distance c, Time d) : base(c, d)
        {
        }
        public override UnitOfMeasure<Velocity> Add(UnitOfMeasure<Velocity> other)
         => new Velocity { Value = Value + (other as Velocity).Convert(this).Value };

        public override UnitOfMeasure<Velocity> Subtract(UnitOfMeasure<Velocity> other)
        => new Velocity { Value = Value - (other as Velocity).Convert(this).Value };
    }

   
}
