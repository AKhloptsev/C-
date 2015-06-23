namespace MyCaffe
{
    public class Espresso : Beverage
    {
        protected string description { get; set; }

        public Espresso()
        {
        }

        public override double Cost()
        {
            return 14.3;
        }

        public override string GetDescription()
        {
            return "Эспрессо";
        }
    }
}