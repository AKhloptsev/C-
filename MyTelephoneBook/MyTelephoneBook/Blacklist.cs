namespace MyTelephoneBook
{
    internal class Blacklist : PersonPhoto
    {
        private bool blacklist;

        public bool _Blacklist
        {
            get { return blacklist; }
            set { blacklist = value; }
        }

        public Blacklist(string _name, string _surname, int _number, string _group, string _photo, bool _blacklist)
            : base(_name, _surname, _number, _group, _photo)
        {
            blacklist = _blacklist;
        }
    }
}