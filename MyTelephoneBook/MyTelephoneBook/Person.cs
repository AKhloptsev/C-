namespace MyTelephoneBook
{
    internal class Person
    {
        private string name;
        private string surname;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public Person(string _name, string _surname)
        {
            name = _name;
            surname = _surname;
        }
    }
}