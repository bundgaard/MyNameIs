namespace MyNameIs
{
    internal class Database
    {
        private static Int64 id = 0;
        private Dictionary<Int64, Person> persons = [];

        public void Insert(string name, string email)
        {
            persons.Add(id++, new Person(name, email));
        }

        public IEnumerable<Person> GetAll()
        {
            return persons.Values;
        }

        public void SaveToFile(string filename)
        {
            List<Person> foo = [];
        }

    }
    struct Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;

        }

        public override string ToString()
        {
            return $"{Name} {Email}";
        }
    }

}
