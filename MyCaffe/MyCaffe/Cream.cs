namespace MyCaffe
{
    public class Cream : AdditivesForBeverage
    {
        protected Beverage beverage;

        public Cream(Beverage b)
        {
            this.beverage = b;
        }

        public override double Cost()
        {
            return beverage.Cost() + 1.5;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " + сливки";
        }
    }
}