namespace MyCaffe
{
    public class BlackTea : Tea
    {
        protected string description { get; set; }

        public BlackTea()
        {
        }

        public override double Cost()
        {
            return 6.5;
        }

        public override string GetDescription()
        {
            return "Чёрный чай";
        }
    }
}