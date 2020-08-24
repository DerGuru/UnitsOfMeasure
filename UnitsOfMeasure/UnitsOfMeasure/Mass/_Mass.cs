namespace UnitsOfMeasure
{
    public abstract class Mass : UnitOfMeasure<Mass>
    {
        protected Mass() { }
        protected Mass(double value) : base(value) { }
    }

    public abstract class Mass<T> : Mass where T : Mass<T>, new()
    {
        protected Mass() { }
        protected Mass(double value) : base(value) { }

        public override int CompareTo(Mass other) => Value.CompareTo(other.ConvertTo<T>().Value);

        public override bool Equals(Mass other) => Value.Equals(other.ConvertTo<T>().Value);

        public override UnitOfMeasure<Mass> Add(UnitOfMeasure<Mass> other)
            => new T { Value = Value + (other as Mass).ConvertTo<T>().Value };

        public override UnitOfMeasure<Mass> Subtract(UnitOfMeasure<Mass> other)
            => new T { Value = Value - (other as Mass).ConvertTo<T>().Value };
    }
}
