namespace MyTelephoneBook
{
    internal class PersonGroup : NumberPhone
    {
        private string group;

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public PersonGroup(string _name, string _surname, int _number, string _group)
            : base(_name, _surname, _number)
        {
            group = _group;
        }
    }
}