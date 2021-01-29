using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    //Mass of gem stones
    public class Carat : Mass
    {
        public Carat() { }

        public Carat(BigDouble value) : base(value) { }

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1) / new BigDouble(5);
        
        public override string Unit => "ct";
    }
}
