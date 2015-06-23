namespace MyCaffe
{
    public abstract class Tea : Beverage
    {
        public Tea()
        {
        }

        public override abstract double Cost();

        public override abstract string GetDescription();
    }
}