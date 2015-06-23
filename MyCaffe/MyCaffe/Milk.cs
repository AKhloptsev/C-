namespace MyCaffe
{
    public class Milk : AdditivesForBeverage
    {
        protected Beverage beverage;

        public Milk(Beverage b)
        {
            this.beverage = b;
        }

        public override double Cost()
        {
            return beverage.Cost() + 1.5;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " + молоко";
        }
    }
}