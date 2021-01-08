namespace UnitsOfMeasure
{
    public abstract class Compound<UnitT, Source1T, Source2T> : UnitOfMeasure<UnitT>
        where UnitT : UnitOfMeasure<UnitT>
        where Source1T : UnitOfMeasure<Source1T>
        where Source2T : UnitOfMeasure<Source2T>
    {
        protected double factorToBaseUnit;
        internal override double FactorToBaseUnit => factorToBaseUnit;

        protected string siUnit;
        public override string SiUnit => siUnit;
        public override void SetSiUnit(string unit)
        {
            siUnit = unit;
        }
        public override T Convert<T>(T target) 
        {
            var t = target.Clone() as T;
            t.SetSiUnit(target.SiUnit);
            t.Value = (target?.FactorToBaseUnit.Equals(FactorToBaseUnit) ?? false)
                ? Value
                : Value * FactorToBaseUnit / target.FactorToBaseUnit;
            return t;
        }
    }
}
