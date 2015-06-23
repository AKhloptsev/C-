namespace MyCaffe
{
    public class GreenTea : Tea
    {
        protected string description { get; set; }

        public GreenTea()
        {
        }

        public override double Cost()
        {
            return 7;
        }

        public override string GetDescription()
        {
            return "Зелёный чай";
        }
    }
}