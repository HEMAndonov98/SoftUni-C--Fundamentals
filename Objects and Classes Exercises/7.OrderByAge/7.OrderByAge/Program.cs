using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.OrderByAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPeople = new List<Person>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] personArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string personName = personArgs[0];
                string personId = personArgs[1];
                int personAge = int.Parse(personArgs[2]);

                Person existingPerson = listOfPeople.FirstOrDefault(p => p.Id == personId);

                if (existingPerson != null)
                {
                    existingPerson.Name = personName;
                    existingPerson.Age = personAge;

                    continue;
                }

                Person newPerson = new Person(personName, personId, personAge);
                listOfPeople.Add(newPerson);
            }

            List<Person> sortedListOfPeople = listOfPeople.OrderBy(p => p.Age).ToList();


            Console.WriteLine(string.Join(Environment.NewLine, sortedListOfPeople));
        }
    }
}
