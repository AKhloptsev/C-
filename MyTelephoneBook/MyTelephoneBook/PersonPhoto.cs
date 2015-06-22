namespace MyTelephoneBook
{
    internal class PersonPhoto : PersonGroup
    {
        private string photo;

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public PersonPhoto(string _name, string _surname, int _number, string _group, string _photo)
            : base(_name, _surname, _number, _group)
        {
            photo = _photo;
        }
    }
}