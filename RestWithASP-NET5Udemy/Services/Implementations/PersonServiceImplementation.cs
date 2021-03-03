using RestWithASP_NET5Udemy.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonServices
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = new Person
                {
                    Id = i,
                    FirstName = $"Ariovaldo - {i}",
                    LastName = $"Silva - {i}",
                    Address = $"Araraquara - São Paulo - {i}",
                    Gender = "Male"
                };

                people.Add(person);
            }

            return people;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Ariovaldo",
                LastName = "Silva",
                Address = "Araraquara - São Paulo",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
