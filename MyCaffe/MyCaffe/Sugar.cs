namespace MyCaffe
{
    public class Sugar : AdditivesForBeverage
    {
        protected Beverage beverage;

        public Sugar(Beverage b)
        {
            this.beverage = b;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.5;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " + сахар";
        }
    }
}