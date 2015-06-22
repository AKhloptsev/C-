namespace MyTelephoneBook
{
    internal class NumberPhone : Person
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public NumberPhone(string _name, string _surname, int _number)
            : base(_name, _surname)
        {
            number = _number;
        }
    }
}