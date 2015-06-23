namespace MyCaffe
{
    public class Latte : Beverage
    {
        protected string description { get; set; }

        public Latte()
        {
        }

        public override double Cost()
        {
            return 14.0;
        }

        public override string GetDescription()
        {
            return "Латте";
        }
    }
}