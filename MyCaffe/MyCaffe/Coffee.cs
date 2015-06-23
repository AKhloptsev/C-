namespace MyCaffe
{
    public class Coffee : Beverage
    {
        protected string description { get; set; }

        public Coffee()
        {
        }

        public override double Cost()
        {
            return 11.5;
        }

        public override string GetDescription()
        {
            return "Кофе";
        }
    }
}