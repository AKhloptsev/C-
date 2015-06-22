namespace MyTelephoneBook
{
    internal class Account<T> where T : Person
    {
        protected T[] database;
        private int i;

        public int Size
        {
            get { return i; }
            set { i = value; }
        }

        public Account()
        {
            i = 0;
            database = new T[50];
        }

        public void Add(T obj)
        {
            if (i < 50)
            {
                database[i] = obj;
                i++;
            }
        }

        public void Clear()
        {
            for (int j = 0; j <= i; j++)
            {
                database[j] = null;
            }
            i = 0;
        }

        public T this[int index]
        {
            get { return database[index]; }
            set { database[index] = value; }
        }
    }
}