using System.Collections.Generic;
using System.Linq;

namespace _2.OldestFamilyMember
{
    public class Family
    {
        public Family()
        {
            this.People = new List<Person>();
        }

        public List<Person> People { get; set; }

        public void AddPerson(Person newPerson)
        {
            People.Add(newPerson);
        }

        public Person GetOldestMember()
        {
            int oldestAge = People.Max(p => p.Age);
            Person oldestPerson = People.Find(p => p.Age == oldestAge);

            return oldestPerson;
        }
    }
}
