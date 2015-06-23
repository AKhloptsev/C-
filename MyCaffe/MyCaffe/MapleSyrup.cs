namespace MyCaffe
{
    public class MapleSyrup : AdditivesForBeverage
    {
        protected Beverage beverage;

        public MapleSyrup(Beverage b)
        {
            this.beverage = b;
        }

        public override double Cost()
        {
            return beverage.Cost() + 1.5;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " + кленовый сироп";
        }
    }
}