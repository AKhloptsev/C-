namespace MyCaffe
{
    public abstract class AdditivesForBeverage : Beverage
    {
        public AdditivesForBeverage()
        {
        }

        public override abstract double Cost();

        public override abstract string GetDescription();
    }
}