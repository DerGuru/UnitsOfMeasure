using System.Numerics;

namespace UnitsOfMeasure
{
    public abstract class Compound<UnitT, Source1T, Source2T> : UnitOfMeasure<UnitT>
        where UnitT : UnitOfMeasure<UnitT>
        where Source1T : UnitOfMeasure<Source1T>
        where Source2T : UnitOfMeasure<Source2T>
    {
        protected BigFloat factorToBaseUnit;
        public override BigFloat FactorToBaseUnit => factorToBaseUnit;

        protected string unit;
        public override string Unit => unit;
        public override void SetUnit(string unit)
        {
            this.unit = unit;
        }
        
    }
}


