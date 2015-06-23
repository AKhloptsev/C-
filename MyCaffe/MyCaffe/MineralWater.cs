namespace MyCaffe
{
    public class MineralWater : Beverage
    {
        protected string description { get; set; }

        public MineralWater()
        {
        }

        public override double Cost()
        {
            return 7.5;
        }

        public override string GetDescription()
        {
            return "Минеральная вода";
        }
    }
}