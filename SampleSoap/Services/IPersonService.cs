using System;
using System.Collections.Generic;
using System.ServiceModel;
using SampleSoap.Models;

namespace SampleSoap.Services
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        PersonModel GetPerson(int Id);
    }

    public class PersonService : IPersonService
    {
        List<PersonModel> persons;
        public PersonService()
        {
            persons = new List<PersonModel>
            {
                new PersonModel(){Id = 1, Name = "User 1", Email = "user1@test.com"},
                new PersonModel(){Id = 2, Name = "User 2", Email = "user2@test.com"},
                new PersonModel(){Id = 3, Name = "User 3", Email = "user3@test.com"},
            };
        }

        public PersonModel GetPerson(int Id)
        {
            return persons.Find(x => x.Id == Id);
        }
    }
}
