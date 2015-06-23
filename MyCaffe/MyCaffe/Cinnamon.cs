namespace MyCaffe
{
    public class Cinnamon : AdditivesForBeverage
    {
        protected Beverage beverage;

        public Cinnamon(Beverage b)
        {
            this.beverage = b;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.5;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " + корица";
        }
    }
}