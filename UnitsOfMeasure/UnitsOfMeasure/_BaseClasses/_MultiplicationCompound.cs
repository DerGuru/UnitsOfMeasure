namespace UnitsOfMeasure
{

    public abstract class MultiplicationCompound<UnitT, Source1T, Source2T> : Compound<UnitT, Source1T, Source2T>
        where UnitT : MultiplicationCompound<UnitT, Source1T, Source2T>
        where Source1T : UnitOfMeasure<Source1T>
        where Source2T : UnitOfMeasure<Source2T>
    {
        public MultiplicationCompound(Source1T a, Source2T b) 
        {
            Value = a.Value * b.Value;
            factorToBaseUnit = a.FactorToBaseUnit * b.FactorToBaseUnit;
            siUnit = $"{a.SiUnit}{b.SiUnit}";
        }
    }
}
